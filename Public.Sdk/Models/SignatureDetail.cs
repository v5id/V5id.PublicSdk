namespace V5id.Public.Sdk.Models;

using System;

public class SignatureDetail
{
    public Guid SignatureDetailUuid { get; init; }

    public required BoundingBox BoundingBox { get; init; }

    public required SignatureImage ClearedImage { get; init; }
    
    public required SignatureImage OriginalImage { get; init; }

    public double Probability { get; init; }
}