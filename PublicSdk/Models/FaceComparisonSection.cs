// © Copyright (c) V5iD, Inc. All rights reserved.
// Licensed under the MIT.

using System.Collections.Generic;

namespace V5iD.PublicSdk.Models
{
    public class FaceComparisonSection
    {
        public Tooltip? Tooltip { get; init; }
        
        public IList<FaceCompare>? FaceCompareResults { get; init; }

        public FaceCompare? HighestMatch { get; init; }
    }
}