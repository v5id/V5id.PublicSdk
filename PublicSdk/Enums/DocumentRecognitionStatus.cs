// © Copyright (c) V5iD, Inc. All rights reserved.
// Licensed under the MIT.

namespace V5iD.PublicSdk.Enums;

using System.Text.Json.Serialization;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum DocumentRecognitionStatus
{
    Unrecognized = 0,
    Successful = 1,
    Warning = 2,
    Error = 3
}