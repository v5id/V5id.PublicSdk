namespace V5iD.PublicSdk.Models;

using System;

public class FaceDetail
{
    public Guid FaceDetailUuid { get; init; }

    public BoundingBox? BoundingBox { get; init; }

    public Pose? Pose { get; init; }

    public AgeRange? AgeRange { get; init; }
    
    public FacialHair? FacialHair { get; init; }
    
    public required string FileName { get; set; }

    public required string ContainerName { get; set; }

    public required string StorageType { get; set; }
}