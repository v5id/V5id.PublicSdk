// © Copyright (c) Renet Consulting, Inc. All right reserved.
// Licensed under the MIT.

using System;
using System.Text.Json;
using Environment = V5iD.PublicSdk.Enums.Environment;

namespace V5iD.PublicSdk.Options
{
    public class VerificationSdkOptions
    {
        /// <summary>
        /// In case of using custom API base url.
        /// </summary>
        public string? CustomerApiBaseUrl { get; set; }

        /// <summary>
        /// In case of using custom API base url.
        /// </summary>
        public string? UploaderApiBaseUrl { get; set; }
        
        public Environment Environment { get; set; } = Environment.Production;

        public required string IntegrationUuid { get; set; }

        public required string IntegrationSecret { get; set; }

        public bool ThrowOnErrorStatusCode { get; set; } = true;

        /// <summary>Кастомные Json-настройки (если нужно).</summary>
        public JsonSerializerOptions? JsonSerializerOptions { get; set; }

        /// <summary>Таймаут HttpClient, если создаётся внутри SDK.</summary>
        public TimeSpan HttpTimeout { get; set; } = TimeSpan.FromSeconds(100);
    }
}