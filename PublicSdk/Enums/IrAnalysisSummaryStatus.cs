// © Copyright (c) V5iD, Inc. All rights reserved.
// Licensed under the MIT.

namespace V5iD.PublicSdk.Enums;

using System.Text.Json.Serialization;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum IrAnalysisSummaryStatus
{
    NotEvaluated = 0,
    Valid = 1,
    Invalid = 2,
}
