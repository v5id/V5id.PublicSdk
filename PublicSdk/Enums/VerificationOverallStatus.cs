// © Copyright (c) V5iD, Inc. All rights reserved.
// Licensed under the MIT.

namespace V5iD.PublicSdk.Enums;

using System.Text.Json.Serialization;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum VerificationOverallStatus
{
    None = 0,
    Processing = 1,
    Success = 2,
    Fail = 3,
    Warning = 4
}