// © Copyright (c) V5iD, Inc. All rights reserved.
// Licensed under the MIT.

namespace V5iD.PublicSdk.Enums;

using System.Text.Json.Serialization;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum VerificationState
{
    None = 0,
    NotStarted = 1,
    Active = 2,
    Completed = 3,
    Inactive = 4,
    Disabled = 5,
    PendingDeletion = 6,
    Deleted = 7,
}