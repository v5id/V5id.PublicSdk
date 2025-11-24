// © Copyright (c) V5iD, Inc. All right reserved.
// Licensed under the MIT.

namespace V5iD.PublicSdk.Models;

using System;

public class SignatureDetail
{
    public Guid SignatureDetailUuid { get; init; }

    public required BoundingBox BoundingBox { get; init; }

    public required SignatureImage ClearedImage { get; init; }
    
    public required SignatureImage OriginalImage { get; init; }

    public double Probability { get; init; }
}