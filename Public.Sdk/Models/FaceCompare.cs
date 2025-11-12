namespace V5id.Public.Sdk.Models;

using System;

public class FaceCompare
{
    public Guid FaceCompareResultUuid { get; init; }

    public required Guid SourceFace { get; init; }

    public required Guid TargetFace { get; init; }

    public double CompareResult { get; init; }
}