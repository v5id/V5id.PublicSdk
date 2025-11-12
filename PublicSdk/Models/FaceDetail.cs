namespace V5id.PublicSdk.Models;

using System;

public class FaceDetail
{
    public Guid FaceDetailUuid { get; init; }

    public BoundingBox? BoundingBox { get; init; }

    public Pose? Pose { get; init; }

    public AgeRange? AgeRange { get; init; }
}