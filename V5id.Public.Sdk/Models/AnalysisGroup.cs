namespace V5id.Public.Sdk.Models;

public record AnalysisGroup(
    string GroupKey,
    string Description,
    string? Tooltip,
    List<AnalysisItem> Items,
    int Order
);