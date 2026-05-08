// © Copyright (c) V5iD, Inc. All rights reserved.
// Licensed under the MIT.

namespace V5iD.PublicSdk.Models;

public class IrSideAnalysis
{
    public bool Valid { get; init; }

    public IrValidationDetails ValidationError { get; init; } = new();
}
