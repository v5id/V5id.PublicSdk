// © Copyright (c) V5iD, Inc. All right reserved.
// Licensed under the MIT.

namespace V5iD.PublicSdk.Enums;

using System.Text.Json.Serialization;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum OverallAnalysisStatus
{
    NotPerformed = 0,
    Started = 1,
    Completed = 2
}