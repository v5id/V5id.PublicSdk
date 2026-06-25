// © Copyright (c) V5iD, Inc. All rights reserved.
// Licensed under the MIT.

namespace V5iD.PublicSdk.Models;

using System;

using V5iD.PublicSdk.Enums;

public class FaceDetail
{
    public Guid FaceDetailUuid { get; init; }

    public BoundingBox? BoundingBox { get; init; }

    public Pose? Pose { get; init; }

    public AgeRange? AgeRange { get; init; }

    /// <summary>Classification of this face (large / ghost / known). Set for document faces only.</summary>
    public FaceType FaceType { get; init; }
}