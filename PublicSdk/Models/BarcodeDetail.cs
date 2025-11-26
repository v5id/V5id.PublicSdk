// © Copyright (c) V5iD, Inc. All rights reserved.
// Licensed under the MIT.

namespace V5iD.PublicSdk.Models;

using System;
using System.Collections.Generic;

public class BarcodeDetail
{
    public Guid BarcodeUuid { get; init; }

    public BarcodePdf417Formatted FormattedBarcode { get; init; } = new();
    
    public ICollection<BarcodeAnalysisGroup>? BarcodeAnalysis { get; init; }
}