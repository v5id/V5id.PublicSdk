// © Copyright (c) V5iD, Inc. All rights reserved.
// Licensed under the MIT.

namespace V5iD.PublicSdk.Enums;

using System.Text.Json.Serialization;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum VerificationStatus
{
    None = 0,
    Processing = 1,
    Success = 2,
    Failed = 3,
    Warning = 4
}