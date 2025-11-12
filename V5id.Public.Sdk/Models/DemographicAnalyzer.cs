namespace V5id.Public.Sdk.Models;

using Enums;

public class DemographicAnalyzer
{
    public Guid Uuid { get; init; }
    
    public DemographicAnalysisType DemographicAnalysisFields { get; init; }

    public ComparisonStatus ValidationStatus { get; init; }
}