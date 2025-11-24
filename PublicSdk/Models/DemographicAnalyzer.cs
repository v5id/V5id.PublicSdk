// © Copyright (c) V5iD, Inc. All right reserved.
// Licensed under the MIT.

namespace V5iD.PublicSdk.Models;

using System;
using V5iD.PublicSdk.Enums;

public class DemographicAnalyzer
{
    public Guid Uuid { get; init; }
    
    public DemographicAnalysisType DemographicAnalysisFields { get; init; }

    public ComparisonStatus ValidationStatus { get; init; }
}