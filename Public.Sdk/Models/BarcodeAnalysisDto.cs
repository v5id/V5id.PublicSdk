namespace V5id.Public.Sdk.Models;

using Enums;

public record BarcodeAnalysisDto(
    string TypeKey,
    string Description,
    string? Tooltip,
    DocumentRecognitionStatus AnalysisStatus
    );