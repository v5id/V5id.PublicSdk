// © Copyright (c) V5iD, Inc. All rights reserved.
// Licensed under the MIT.

using V5iD.PublicSdk.Enums;

namespace V5iD.PublicSdk.Models;

using System;

public class FaceCompare
{
    public Guid FaceCompareResultUuid { get; init; }

    public required Guid SourceFace { get; init; }

    public required Guid TargetFace { get; init; }

    public double Similarity { get; init; }
    
    public ComparisonResult ComparisonResult { get; init; }
}