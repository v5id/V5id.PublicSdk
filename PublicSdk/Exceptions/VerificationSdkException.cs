// © Copyright (c) V5iD, Inc. All right reserved.
// Licensed under the MIT.

using System;
using System.Net;

namespace V5iD.PublicSdk.Exceptions
{
    public sealed class VerificationSdkException : Exception
    {
        public HttpStatusCode StatusCode { get; }
        public string? ResponseBody { get; }

        public VerificationSdkException(
            string message,
            HttpStatusCode statusCode,
            string? responseBody = null,
            Exception? innerException = null)
            : base(message, innerException)
        {
            StatusCode = statusCode;
            ResponseBody = responseBody;
        }

        public VerificationSdkException()
        {
        }

        public VerificationSdkException(string message) : base(message)
        {
        }

        public VerificationSdkException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}