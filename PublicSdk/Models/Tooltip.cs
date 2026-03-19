// © Copyright (c) V5iD, Inc. All rights reserved.
// Licensed under the MIT.

using System.Collections.Generic;

namespace V5iD.PublicSdk.Models
{
    public class Tooltip
    {
        public required string Title { get; init; }
        
        public IList<TooltipItem> Items { get; init; } = [];
    }
}