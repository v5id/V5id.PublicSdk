namespace V5id.Public.Sdk.Models;

public record BarcodeAnalysisGroup(
    string GroupKey,
    string Description,
    string? Tooltip,
    List<BarcodeAnalysisDto> Items,
    int Order
    );