// © Copyright (c) V5iD, Inc. All rights reserved.
// Licensed under the MIT.

using System.Text.Json.Serialization;

namespace V5iD.PublicSdk.Models
{
    internal class TokenRequest
    {
        [JsonPropertyName("client_id")]
        internal string ClientId { get; set; } = string.Empty;

        [JsonPropertyName("client_secret")]
        internal string ClientSecret { get; set; } = string.Empty;

        [JsonPropertyName("grant_type")]
        internal string GrantType { get; set; } = string.Empty;
    }
}