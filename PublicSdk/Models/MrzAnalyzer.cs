namespace V5iD.PublicSdk.Models;

using System;
using V5iD.PublicSdk.Enums;

public class MrzAnalyzer
{
    public Guid Uuid { get; init; }

    public DocumentFieldType DocumentFieldType { get; init; }

    public ComparisonStatus ComparisonStatus { get; init; }
}