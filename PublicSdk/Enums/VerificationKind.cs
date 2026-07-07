// © Copyright (c) V5iD, Inc. All rights reserved.
// Licensed under the MIT.

namespace V5iD.PublicSdk.Enums;

using System.Text.Json.Serialization;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum VerificationKind
{
    Full = 0,

    StandaloneBarcode = 1,

    StandaloneMrz = 2
}
