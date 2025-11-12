namespace V5id.Public.Sdk.Models;

using System.Collections.Generic;

public record BarcodeAnalysisGroup(
    string GroupKey,
    string Description,
    string? Tooltip,
    IList<BarcodeAnalysisDto> Items,
    int Order
    );