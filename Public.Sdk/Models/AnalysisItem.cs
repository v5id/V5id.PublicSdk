namespace V5id.Public.Sdk.Models;

using Enums;

public record AnalysisItem(
    string TypeKey,
    string Description,
    string? Tooltip,
    DocumentRecognitionStatus AnalysisStatus
    );