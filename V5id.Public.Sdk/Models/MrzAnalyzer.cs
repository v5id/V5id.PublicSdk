namespace V5id.Public.Sdk.Models;

using Enums;

public class MrzAnalyzer
{
    public Guid Uuid { get; init; }

    public DocumentFieldType DocumentFieldType { get; init; }

    public ComparisonStatus ComparisonStatus { get; init; }
}