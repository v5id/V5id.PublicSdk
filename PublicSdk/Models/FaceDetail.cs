// © Copyright (c) V5iD, Inc. All right reserved.
// Licensed under the MIT.

namespace V5iD.PublicSdk.Models;

using System;

public class FaceDetail
{
    public Guid FaceDetailUuid { get; init; }

    public BoundingBox? BoundingBox { get; init; }

    public Pose? Pose { get; init; }

    public AgeRange? AgeRange { get; init; }
}