// © Copyright (c) V5iD, Inc. All rights reserved.
// Licensed under the MIT.

namespace V5iD.PublicSdk.Models;

using System.Collections.Generic;

public record BarcodeAnalysisGroup(
    string GroupKey,
    string Description,
    string? Tooltip,
    IList<BarcodeAnalysisDto> Items,
    int Order
    );