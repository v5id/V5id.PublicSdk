// © Copyright (c) V5iD, Inc. All right reserved.
// Licensed under the MIT.

using System.Text.Json.Serialization;

namespace V5iD.PublicSdk.Models
{
    internal class TokenResponse
    {
        [JsonPropertyName("access_token")]
        internal string AccessToken { get; set; } = string.Empty;

        [JsonPropertyName("expires_in")]
        internal int ExpiresIn { get; set; } = 3600;

        [JsonPropertyName("refresh_token")]
        internal string RefreshToken { get; set; } = string.Empty;

        [JsonPropertyName("token_type")]
        internal string TokenType { get; set; } = "Bearer";
    }
}