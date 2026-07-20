// © Copyright (c) V5iD, Inc. All rights reserved.
// Licensed under the MIT.

namespace V5iD.PublicSdk.Models;

using V5iD.PublicSdk.Enums;

public class OverallAnalysis
{
    public OverallMismatchType OverallMismatchType { get; init; }
    
    public OverallAnalysisStatus AnalysisStatus { get; init; }

    public ComparisonResult AnalysisResult { get; init; }

    /// <summary>
    /// False when the analysed value was not found at all (e.g. no age on the document), as opposed to
    /// found-and-mismatched. <see cref="AnalysisResult"/> still carries the business outcome.
    /// </summary>
    public bool IsDetected { get; init; } = true;
}