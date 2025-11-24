// © Copyright (c) V5iD, Inc. All right reserved.
// Licensed under the MIT.

using System.Net;

namespace V5iD.PublicSdk.Models;

/// <summary>
/// Represents the result of an operation, encapsulating success or failure states,
/// status code, optional error details, and an optional value for successful operations.
/// </summary>
/// <typeparam name="T">The type of the value returned on successful operation.</typeparam>
public sealed class OperationResult<T>
{
    public bool IsSuccess { get; init; }
    public HttpStatusCode StatusCode { get; init; }
    public string? ErrorMessage { get; init; }
    public string? RawResponseBody { get; init; }
    public T? Value { get; init; }

    public static OperationResult<T> Success(T? value, HttpStatusCode statusCode)
        => new()
        {
            IsSuccess = true,
            StatusCode = statusCode,
            Value = value
        };

    public static OperationResult<T> Failure(
        HttpStatusCode statusCode,
        string? errorMessage,
        string? rawResponseBody = null)
        => new()
        {
            IsSuccess = false,
            StatusCode = statusCode,
            ErrorMessage = errorMessage,
            RawResponseBody = rawResponseBody
        };
}