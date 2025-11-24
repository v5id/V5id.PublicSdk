// © Copyright (c) V5iD, Inc. All right reserved.
// Licensed under the MIT.

namespace V5iD.PublicSdk.Models;

using V5iD.PublicSdk.Enums;

public class OverallAnalysis
{
    public OverallMismatchType OverallMismatchType { get; init; }
    
    public OverallAnalysisStatus AnalysisStatus { get; init; }

    public ComparisonResult AnalysisResult { get; init; }
}