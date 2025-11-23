namespace V5iD.PublicSdk.Models;

using V5iD.PublicSdk.Enums;

public record AnalysisItem(
    string TypeKey,
    string Description,
    string? Tooltip,
    DocumentRecognitionStatus AnalysisStatus
    );