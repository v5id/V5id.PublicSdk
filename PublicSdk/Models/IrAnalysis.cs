// © Copyright (c) V5iD, Inc. All rights reserved.
// Licensed under the MIT.

namespace V5iD.PublicSdk.Models;

using V5iD.PublicSdk.Enums;

public class IrAnalysis
{
    public IrAnalysisSummaryStatus SummaryStatus { get; init; }

    public IrSideAnalysis? Front { get; init; }

    public IrSideAnalysis? Back { get; init; }
}
