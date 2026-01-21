// © Copyright (c) V5iD, Inc. All rights reserved.
// Licensed under the MIT.

using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Options;
using V5iD.PublicSdk.Enums;
using V5iD.PublicSdk.Exceptions;
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
        private int _disposed;

        private readonly SemaphoreSlim _tokenLock = new(1, 1);
        private TokenResponse? _cachedToken;
        private DateTimeOffset _tokenExpiresAtUtc;
        private double _tokenExpiresInSeconds;

        private static readonly TimeSpan ClockSkew = TimeSpan.FromSeconds(5);

        public V5iDClient(
            IOptions<VerificationSdkOptions> options,
            HttpClient? customerClient = null,
            HttpClient? uploaderClient = null)
        {
            _options = options.Value ?? throw new ArgumentNullException(nameof(options));

            if (string.IsNullOrWhiteSpace(_options.CustomerApiBaseUrl))
                throw new ArgumentException("CustomerApiBaseUrl must be set", nameof(options));

            if (string.IsNullOrWhiteSpace(_options.UploaderApiBaseUrl))
                throw new ArgumentException("UploaderApiBaseUrl must be set", nameof(options));

            _customerClient = customerClient ?? new HttpClient();
            if (customerClient is null)
            {
                _ownsCustomerClient = true;
                _customerClient.BaseAddress = new Uri(_options.CustomerApiBaseUrl, UriKind.Absolute);
                _customerClient.Timeout = _options.HttpTimeout;
            }

            _uploaderClient = uploaderClient ?? new HttpClient();
            if (uploaderClient is null)
            {
                _ownsUploaderClient = true;
                _uploaderClient.BaseAddress = new Uri(_options.UploaderApiBaseUrl, UriKind.Absolute);
                _uploaderClient.Timeout = _options.HttpTimeout;
            }
        }

        protected virtual void Dispose(bool disposing)
        {
            if (Interlocked.Exchange(ref _disposed, 1) != 0)
                return;

            if (disposing)
            {
                _tokenLock?.Dispose();

                if (_ownsCustomerClient)
                    _customerClient?.Dispose();

                if (_ownsUploaderClient)
                    _uploaderClient?.Dispose();
            }
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

        private bool IsTokenFresh()
        {
            if (_cachedToken?.AccessToken is null)
                return false;

            var now = DateTimeOffset.UtcNow;

            if (now >= _tokenExpiresAtUtc)
                return false;

            var remaining = _tokenExpiresAtUtc - now;

            var refreshThreshold = TimeSpan.FromSeconds(_tokenExpiresInSeconds * 0.10);

            return remaining > (refreshThreshold + ClockSkew);
        }

        private void CacheToken(TokenResponse token)
        {
            _cachedToken = token;

            var expiresIn = token.ExpiresIn > 0 ? token.ExpiresIn : 3600;
            _tokenExpiresInSeconds = expiresIn;

            _tokenExpiresAtUtc = DateTimeOffset.UtcNow.AddSeconds(expiresIn);
        }

        private async Task<OperationResult<TokenResponse>> EnsureTokenAsync(
            CancellationToken cancellationToken = default)
        {
            if (IsTokenFresh())
            {
                return OperationResult<TokenResponse>.Success(_cachedToken, HttpStatusCode.OK);
            }

            await _tokenLock.WaitAsync(cancellationToken).ConfigureAwait(false);
            try
            {
                if (IsTokenFresh())
                {
                    return OperationResult<TokenResponse>.Success(_cachedToken, HttpStatusCode.OK);
                }

                var tokenOperation = await GetTokenAsync(cancellationToken).ConfigureAwait(false);

                if (!tokenOperation.IsSuccess || tokenOperation.Value is null)
                {
                    return tokenOperation;
                }

                CacheToken(tokenOperation.Value);
                return tokenOperation;
            }
            finally
            {
                _tokenLock.Release();
            }
        }

        public async Task<OperationResult<CreatedVerification>> CreateVerificationAsync(
            CancellationToken cancellationToken = default)
        {
            return await CreateVerification(cancellationToken).ConfigureAwait(false);
        }

        public async Task<OperationResult<CreatedWebVerification>> CreateWebVerificationAsync(
            string? referenceId = null,
            CancellationToken cancellationToken = default)
        {
            var verificationResult = await CreateVerification(cancellationToken, CustomerApiEndpoints.CreateWebVerification, ("referenceId", referenceId)).ConfigureAwait(false);

            if (!verificationResult.IsSuccess || verificationResult.Value is null)
            {
                return new OperationResult<CreatedWebVerification>
                {
                    IsSuccess = false,
                    StatusCode = verificationResult.StatusCode,
                    ErrorMessage = verificationResult.ErrorMessage,
                    RawResponseBody = verificationResult.RawResponseBody,
                };
            }

            return new OperationResult<CreatedWebVerification>
            {
                IsSuccess = true,
                StatusCode = HttpStatusCode.Created,
                ErrorMessage = null,
                RawResponseBody = null,
                Value = new CreatedWebVerification
                {
                    VerificationUuid = verificationResult.Value.VerificationUuid,
                    IsWaitForStartVerification = verificationResult.Value.IsWaitForStartVerification,
                    IntegrationScopes = verificationResult.Value.IntegrationScopes,
                    RedirectUrl = $"{_options.VerifyBaseUrl}/get-started?verificationId={verificationResult.Value.VerificationUuid}"
                }
            };
        }

        public async Task<OperationResult<Verification>> GetVerificationAsync(
            CancellationToken cancellationToken = default)
        {
            using var request = new HttpRequestMessage(
                HttpMethod.Get,
                CustomerApiEndpoints.GetVerification);

            var tokenOperation = await EnsureTokenAsync(cancellationToken).ConfigureAwait(false);

            if (!tokenOperation.IsSuccess)
            {
                if (_options.ThrowOnErrorStatusCode)
                {
                    throw new VerificationSdkException(
                        "Unable to authenticate user",
                        tokenOperation.StatusCode);
                }

                return OperationResult<Verification>.Failure(
                    tokenOperation.StatusCode, "Unable to authenticate user", rawResponseBody: tokenOperation.RawResponseBody);
            }

            request.Headers.Authorization =
                new AuthenticationHeaderValue("Bearer", tokenOperation.Value!.AccessToken);

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
            bool leaveOpen = false,
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

            var path = pathTemplate.Replace(
                "{verificationUuid}",
                Uri.EscapeDataString(verificationUuid),
                StringComparison.Ordinal);

            var fieldName = fileType switch
            {
                FileType.FaceImage => "faceImage",
                _ => "document"
            };

            if (fileStream.CanSeek) fileStream.Position = 0;

            Stream streamForContent = leaveOpen
                ? new NonDisposingStream(fileStream)
                : fileStream;

            using var content = new MultipartFormDataContent();
            using var fileContent = new StreamContent(streamForContent);
            fileContent.Headers.ContentType = new MediaTypeHeaderValue(contentType);
            content.Add(fileContent, fieldName, fileName);

            using var request = new HttpRequestMessage(HttpMethod.Post, path)
            {
                Content = content
            };

            var tokenOperation = await EnsureTokenAsync(cancellationToken).ConfigureAwait(false);

            if (!tokenOperation.IsSuccess)
            {
                if (_options.ThrowOnErrorStatusCode)
                {
                    throw new VerificationSdkException(
                        "Unable to authenticate user",
                        tokenOperation.StatusCode);
                }

                return OperationResult<NewUploadedFile>.Failure(
                    tokenOperation.StatusCode, "Unable to authenticate user", rawResponseBody: tokenOperation.RawResponseBody);
            }

            request.Headers.Authorization =
                new AuthenticationHeaderValue("Bearer", tokenOperation.Value!.AccessToken);

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
        
        private async Task<OperationResult<CreatedVerification>> CreateVerification(CancellationToken cancellationToken, string requestUri = CustomerApiEndpoints.CreateVerification, params (string Name, string? Value)[] queryParams)
        {
            var finalUri = requestUri;

            if (queryParams.Length != 0)
            {
                var filteredParams = queryParams.Where(p => !string.IsNullOrWhiteSpace(p.Name) && !string.IsNullOrWhiteSpace(p.Value));
                if (!filteredParams.Any())
                {
                    finalUri = QueryHelpers.AddQueryString(
                            requestUri,
                            queryParams
                                .Where(p => !string.IsNullOrWhiteSpace(p.Name) && !string.IsNullOrWhiteSpace(p.Value))
                                .ToDictionary(p => p.Name, p => p.Value ?? string.Empty)!);
                }
            }
            
            using var request = new HttpRequestMessage(
                HttpMethod.Post,
                finalUri);

            var tokenOperation = await EnsureTokenAsync(cancellationToken).ConfigureAwait(false);

            if (!tokenOperation.IsSuccess)
            {
                if (_options.ThrowOnErrorStatusCode)
                {
                    throw new VerificationSdkException(
                        "Unable to authenticate user",
                        tokenOperation.StatusCode);
                }

                return OperationResult<CreatedVerification>.Failure(
                    tokenOperation.StatusCode, "Unable to authenticate user", rawResponseBody: tokenOperation.RawResponseBody);
            }

            request.Headers.Authorization =
                new AuthenticationHeaderValue("Bearer", tokenOperation.Value!.AccessToken);

            using var response = await _customerClient.SendAsync(
                request,
                HttpCompletionOption.ResponseHeadersRead,
                cancellationToken).ConfigureAwait(false);

            return await HandleResponseAsync<CreatedVerification>(
                response,
                "Failed to create verification",
                cancellationToken).ConfigureAwait(false);
        }

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
        
        private sealed class NonDisposingStream : Stream
        {
#pragma warning disable CA2213 Stream should not be disposed. Ownership belongs to the caller.
            private readonly Stream _inner;
#pragma warning restore CA2213
            public NonDisposingStream(Stream inner) => _inner = inner;

            public override bool CanRead => _inner.CanRead;
            public override bool CanSeek => _inner.CanSeek;
            public override bool CanWrite => _inner.CanWrite;
            public override long Length => _inner.Length;
            public override long Position { get => _inner.Position; set => _inner.Position = value; }
            public override void Flush() => _inner.Flush();
            public override int Read(byte[] buffer, int offset, int count) => _inner.Read(buffer, offset, count);
            public override long Seek(long offset, SeekOrigin origin) => _inner.Seek(offset, origin);
            public override void SetLength(long value) => _inner.SetLength(value);
            public override void Write(byte[] buffer, int offset, int count) => _inner.Write(buffer, offset, count);

#pragma warning disable CA2215 Stream should not be disposed. Ownership belongs to the caller.
            protected override void Dispose(bool disposing) { /* leave inner open */ }
            
            public override ValueTask DisposeAsync() => ValueTask.CompletedTask;
#pragma warning restore CA2215
        }

        #endregion
    }
}
