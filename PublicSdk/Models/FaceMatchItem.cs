// © Copyright (c) V5iD, Inc. All rights reserved.
// Licensed under the MIT.

namespace V5iD.PublicSdk.Models;

using V5iD.PublicSdk.Enums;

public record FaceMatchItem(
    string Key,
    string Description,
    string? Tooltip,
    FaceCompare? Result,
    DocumentRecognitionStatus Status
);
