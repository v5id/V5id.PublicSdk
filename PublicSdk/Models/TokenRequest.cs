// © Copyright (c) V5iD, Inc. All rights reserved.
// Licensed under the MIT.

using System.Text.Json.Serialization;

namespace V5iD.PublicSdk.Models
{
    public class TokenRequest
    {
        public string ClientId { get; set; } = string.Empty;

        public string ClientSecret { get; set; } = string.Empty;

        public string GrantType { get; set; } = string.Empty;
    }
}