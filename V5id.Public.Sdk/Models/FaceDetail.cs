namespace V5id.Public.Sdk.Models;

public class FaceDetail
{
    public Guid FaceDetailUuid { get; init; }

    public BoundingBox? BoundingBox { get; init; }

    public Pose? Pose { get; init; }

    public AgeRange? AgeRange { get; init; }
}