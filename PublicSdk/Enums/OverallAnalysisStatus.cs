// © Copyright (c) V5iD, Inc. All rights reserved.
// Licensed under the MIT.

namespace V5iD.PublicSdk.Enums;

using System.Text.Json.Serialization;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum OverallAnalysisStatus
{
    NotPerformed = 0,
    Started = 1,
    Completed = 2,

    // The analysis ran but the item was not found in the document (e.g. no age on the document).
    // Split into Error/Success so the client knows whether the absence failed the verification:
    //   NotDetectedError   — absent AND it caused the check to fail.
    //   NotDetectedSuccess — absent but it did NOT fail the verification (benign).
    // Appended at the end so existing persisted values keep their meaning.
    NotDetectedError = 3,
    NotDetectedSuccess = 4
}