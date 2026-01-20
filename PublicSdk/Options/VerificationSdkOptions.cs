// © Copyright (c) V5iD, Inc. All rights reserved.
// Licensed under the MIT.

using System;
using System.Text.Json;
using Environment = V5iD.PublicSdk.Enums.Environment;

namespace V5iD.PublicSdk.Options
{
    public class VerificationSdkOptions
    {
        /// <summary>
        /// In case of using custom Customer API base url.
        /// </summary>
        public string? CustomerApiBaseUrl { get; set; }

        /// <summary>
        /// In case of using custom Uploader API base url.
        /// </summary>
        public string? UploaderApiBaseUrl { get; set; }
        
        public string? VerifyBaseUrl { get; set; }
        
        public required string IntegrationUuid { get; set; }

        public required string IntegrationSecret { get; set; }

        public bool ThrowOnErrorStatusCode { get; set; } = true;

        public JsonSerializerOptions? JsonSerializerOptions { get; set; }

        public TimeSpan HttpTimeout { get; set; } = TimeSpan.FromSeconds(100);
    }
}