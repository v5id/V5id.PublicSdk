// © Copyright (c) V5iD, Inc. All rights reserved.
// Licensed under the MIT.

using System.Text.Json.Serialization;

namespace V5iD.PublicSdk.Enums
{
    [JsonConverter(typeof (JsonStringEnumConverter))]
    public enum IntegrationScope
    {
        None = 0,
        CompareFaceToDocument = 1,
        ExtractDataOutOfDocument = 2,
        VerifyMobilePhone = 3,
        VerifyEmail = 4,
        VerifySignature = 5,
    }
}