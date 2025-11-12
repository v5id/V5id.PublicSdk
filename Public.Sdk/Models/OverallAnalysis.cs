namespace V5id.PublicSdk.Models;

using V5id.PublicSdk.Enums;

public class OverallAnalysis
{
    public OverallMismatchType OverallMismatchType { get; init; }
    
    public OverallAnalysisStatus AnalysisStatus { get; init; }

    public ComparisonResult AnalysisResult { get; init; }
}