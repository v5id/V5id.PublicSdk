// © Copyright (c) V5iD, Inc. All rights reserved.
// Licensed under the MIT.

using System.Text.Json.Serialization;

namespace V5iD.PublicSdk.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum LivenessStatus
    {
        None = 0,
        Succeeded = 1,
        Failed = 2
    }
}