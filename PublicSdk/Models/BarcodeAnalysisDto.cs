namespace V5id.PublicSdk.Models;

using V5id.PublicSdk.Enums;

public record BarcodeAnalysisDto(
    string TypeKey,
    string Description,
    string? Tooltip,
    DocumentRecognitionStatus AnalysisStatus
    );