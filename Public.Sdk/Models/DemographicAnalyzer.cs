namespace V5id.PublicSdk.Models;

using System;
using V5id.PublicSdk.Enums;

public class DemographicAnalyzer
{
    public Guid Uuid { get; init; }
    
    public DemographicAnalysisType DemographicAnalysisFields { get; init; }

    public ComparisonStatus ValidationStatus { get; init; }
}