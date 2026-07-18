// © Copyright (c) V5iD, Inc. All rights reserved.
// Licensed under the MIT.

namespace V5iD.PublicSdk.Models;

using V5iD.PublicSdk.Enums;

public record AnalysisItem(
    string TypeKey,
    string Description,
    string? Tooltip,
    DocumentRecognitionStatus AnalysisStatus
    )
{
    /// <summary>
    /// False when the checked item is simply not present in the document (e.g. no face printed on this
    /// side), as opposed to present-but-wrong. <see cref="AnalysisStatus"/> still carries the severity:
    /// Error when the absence failed the verification, Warning when it was benign.
    /// </summary>
    public bool IsDetected { get; init; } = true;
}