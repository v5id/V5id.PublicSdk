// © Copyright (c) V5iD, Inc. All right reserved.
// Licensed under the MIT.

namespace V5iD.PublicSdk.Models;

using System;

public class FaceCompare
{
    public Guid FaceCompareResultUuid { get; init; }

    public required Guid SourceFace { get; init; }

    public required Guid TargetFace { get; init; }

    public double CompareResult { get; init; }
}