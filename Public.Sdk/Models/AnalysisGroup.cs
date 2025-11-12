namespace V5id.Public.Sdk.Models;

using System.Collections.Generic;

public record AnalysisGroup(
    string GroupKey,
    string Description,
    string? Tooltip,
    IList<AnalysisItem> Items,
    int Order
);