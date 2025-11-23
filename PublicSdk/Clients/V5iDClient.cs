// © Copyright (c) Renet Consulting, Inc. All right reserved.
// Licensed under the MIT.

using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using V5id.PublicSdk.Enums;
using V5iD.PublicSdk.Exceptions;
using V5id.PublicSdk.Models;
using V5iD.PublicSdk.Models;
using V5iD.PublicSdk.Options;

namespace V5iD.PublicSdk.Clients
{
    public class V5iDClient : IV5iDClient, IDisposable
    { 
        private readonly VerificationSdkOptions _options;
        private readonly HttpClient _customerClient;
        private readonly HttpClient _uploaderClient;
        private readonly bool _ownsCustomerClient;
        private readonly bool _ownsUploaderClient;

    private static readonly JsonSerializerOptions DefaultJsonOptions = new(JsonSerializerDefaults.Web);
    private bool _disposed;
    
    public V5iDClient(
        VerificationSdkOptions options,
        HttpClient? customerClient = null,
        HttpClient? uploaderClient = null)
    {
        _options = options ?? throw new ArgumentNullException(nameof(options));

        if (string.IsNullOrWhiteSpace(options.CustomerApiBaseUrl))
            throw new ArgumentException("CustomerApiBaseUrl must be set", nameof(options));

        if (string.IsNullOrWhiteSpace(options.UploaderApiBaseUrl))
            throw new ArgumentException("UploaderApiBaseUrl must be set", nameof(options));

        _customerClient = customerClient ?? new HttpClient();
        if (customerClient is null)
        {
            _ownsCustomerClient = true;
            _customerClient.BaseAddress = new Uri(options.CustomerApiBaseUrl, UriKind.Absolute);
            _customerClient.Timeout = options.HttpTimeout;
        }

        _uploaderClient = uploaderClient ?? new HttpClient();
        if (uploaderClient is null)
        {
            _ownsUploaderClient = true;
            _uploaderClient.BaseAddress = new Uri(options.UploaderApiBaseUrl, UriKind.Absolute);
            _uploaderClient.Timeout = options.HttpTimeout;
        }
    }

    protected virtual void Dispose(bool disposing)
    {
        if (_disposed)
            return;

        _disposed = true;

        if (_ownsCustomerClient)
            _customerClient.Dispose();

        if (_ownsUploaderClient)
            _uploaderClient.Dispose();
    }

    
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    
    public ValueTask DisposeAsync()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
        return ValueTask.CompletedTask;
    }

    #region CustomerApi

    private Task<OperationResult<TokenResponse>> GetTokenAsync(
        CancellationToken cancellationToken = default)
    {
        var request = new TokenRequest
        {
            ClientId = _options.IntegrationUuid,
            ClientSecret = _options.IntegrationSecret,
            GrantType = "client_credentials"
        };

        return GetTokenAsync(request, cancellationToken);
    }

    private async Task<OperationResult<TokenResponse>> GetTokenAsync(
        TokenRequest request,
        CancellationToken cancellationToken = default)
    {
        using var response = await _customerClient.PostAsJsonAsync(
            CustomerApiEndpoints.Token,
            request,
            _options.JsonSerializerOptions ?? DefaultJsonOptions,
            cancellationToken).ConfigureAwait(false);

        return await HandleResponseAsync<TokenResponse>(
            response,
            "Failed to get access token",
            cancellationToken).ConfigureAwait(false);
    }

    public async Task<OperationResult<CreatedVerification>> CreateVerificationAsync(
        CancellationToken cancellationToken = default)
    {
        using var request = new HttpRequestMessage(
            HttpMethod.Post,
            CustomerApiEndpoints.CreateVerification);
        
        var tokenOperation = await GetTokenAsync(cancellationToken).ConfigureAwait(false);
        
        if (!tokenOperation.IsSuccess)
        {
            if (_options.ThrowOnErrorStatusCode)
            {
                throw new VerificationSdkException("Unable to authenticate user", tokenOperation.StatusCode);
            }

            return OperationResult<CreatedVerification>.Failure(
                tokenOperation.StatusCode, "Unable to authenticate user");
        }

        request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", tokenOperation.Value?.AccessToken);

        using var response = await _customerClient.SendAsync(
            request,
            HttpCompletionOption.ResponseHeadersRead,
            cancellationToken).ConfigureAwait(false);

        return await HandleResponseAsync<CreatedVerification>(
            response,
            "Failed to create verification",
            cancellationToken).ConfigureAwait(false);
    }

    public async Task<OperationResult<Verification>> GetVerificationAsync(
        CancellationToken cancellationToken = default)
    {
        using var request = new HttpRequestMessage(
            HttpMethod.Get,
            CustomerApiEndpoints.GetVerification);

        var tokenOperation = await GetTokenAsync(cancellationToken).ConfigureAwait(false);
        
        if (!tokenOperation.IsSuccess)
        {
            if (_options.ThrowOnErrorStatusCode)
            {
                throw new VerificationSdkException("Unable to authenticate user", tokenOperation.StatusCode);
            }

            return OperationResult<Verification>.Failure(
                tokenOperation.StatusCode, "Unable to authenticate user");
        }

        request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", tokenOperation.Value?.AccessToken);

        using var response = await _customerClient.SendAsync(
            request,
            HttpCompletionOption.ResponseHeadersRead,
            cancellationToken).ConfigureAwait(false);

        return await HandleResponseAsync<Verification>(
            response,
            "Failed to get verification",
            cancellationToken).ConfigureAwait(false);
    }

    #endregion

    #region UploaderApi

    public async Task<OperationResult<NewUploadedFile>> UploadFileAsync(
        FileType fileType,
        string verificationUuid,
        Stream fileStream,
        string fileName,
        string contentType = "application/octet-stream",
        CancellationToken cancellationToken = default)
    {
            ArgumentNullException.ThrowIfNull(fileStream);

            var pathTemplate = fileType switch
        {
            FileType.DocumentFront => UploaderApiEndpoints.UploadFront,
            FileType.DocumentBack => UploaderApiEndpoints.UploadBack,
            FileType.FaceImage => UploaderApiEndpoints.UploadFace,
            _ => throw new ArgumentOutOfRangeException(nameof(fileType), fileType, "Unknown file type.")
        };

        if (string.IsNullOrWhiteSpace(pathTemplate))
            throw new InvalidOperationException($"Path template for {fileType} is not configured.");

        var path = pathTemplate.Replace("{verificationUuid}", Uri.EscapeDataString(verificationUuid), StringComparison.Ordinal);

        var fieldName = fileType switch
        {
            FileType.FaceImage => "faceImage",
            _ => "document"
        };

        using var content = new MultipartFormDataContent();

        using var fileContent = new StreamContent(fileStream);
        fileContent.Headers.ContentType = new MediaTypeHeaderValue(contentType);

        content.Add(fileContent, fieldName, fileName);

        using var request = new HttpRequestMessage(HttpMethod.Post, path);
        request.Content = content;

        var tokenOperation = await GetTokenAsync(cancellationToken).ConfigureAwait(false);
        
        if (!tokenOperation.IsSuccess)
        {
            if (_options.ThrowOnErrorStatusCode)
            {
                throw new VerificationSdkException("Unable to authenticate user", tokenOperation.StatusCode);
            }

            return OperationResult<NewUploadedFile>.Failure(
                tokenOperation.StatusCode, "Unable to authenticate user");
        }

        request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", tokenOperation.Value?.AccessToken);

        using var response = await _uploaderClient.SendAsync(
            request,
            HttpCompletionOption.ResponseHeadersRead,
            cancellationToken).ConfigureAwait(false);

        return await HandleResponseAsync<NewUploadedFile>(
            response,
            "Failed to upload file",
            cancellationToken).ConfigureAwait(false);
    }

    #endregion

    #region Internal helpers

    private async Task<OperationResult<T>> HandleResponseAsync<T>(
        HttpResponseMessage response,
        string errorContext,
        CancellationToken cancellationToken)
    {
        var body = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

        if (!response.IsSuccessStatusCode)
        {
            if (_options.ThrowOnErrorStatusCode)
            {
                throw new VerificationSdkException(
                    $"{errorContext}. StatusCode: {(int)response.StatusCode} ({response.StatusCode}).",
                    response.StatusCode,
                    body);
            }

            return OperationResult<T>.Failure(
                response.StatusCode,
                $"{errorContext}. See RawResponseBody for details.",
                body);
        }

        if (string.IsNullOrWhiteSpace(body))
        {
            return OperationResult<T>.Success(default, response.StatusCode);
        }

        var jsonOptions = _options.JsonSerializerOptions ?? DefaultJsonOptions;

        T? value;
        try
        {
            value = JsonSerializer.Deserialize<T>(body, jsonOptions);
        }
        catch (Exception ex)
        {
            if (_options.ThrowOnErrorStatusCode)
            {
                throw new VerificationSdkException(
                    $"{errorContext}. Failed to deserialize response to {typeof(T).Name}.",
                    response.StatusCode,
                    body,
                    ex);
            }

            return OperationResult<T>.Failure(
                response.StatusCode,
                $"{errorContext}. Failed to deserialize response: {ex.Message}",
                body);
        }

        if (value is null)
        {
            return OperationResult<T>.Failure(
                response.StatusCode,
                $"{errorContext}. Response body is empty or could not be deserialized.",
                body);
        }

        return OperationResult<T>.Success(value, response.StatusCode);
    }

    #endregion
    }
}