// © Copyright (c) V5iD, Inc. All rights reserved.
// Licensed under the MIT.

using System.Text.Json.Serialization;

namespace V5iD.PublicSdk.Models
{
    public class TokenRequest
    {
        [JsonPropertyName("client_id")]
        public string ClientId { get; set; } = string.Empty;

        [JsonPropertyName("client_secret")]
        public string ClientSecret { get; set; } = string.Empty;

        [JsonPropertyName("grant_type")]
        public string GrantType { get; set; } = string.Empty;
    }
}