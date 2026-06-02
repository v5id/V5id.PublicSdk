// © Copyright (c) V5iD, Inc. All rights reserved.
// Licensed under the MIT.

using System.Collections.Generic;

namespace V5iD.PublicSdk.Models
{
    public class FaceComparisonSection
    {
        public Tooltip? Tooltip { get; init; }
        
        public IList<FaceCompare>? FaceCompareResults { get; init; }

        /// <summary>
        /// The worst selfie-to-document comparison — surfaced in the summary as "Selfie-to-Document Match".
        /// Null when the verification has no selfie↔document compare.
        /// </summary>
        public FaceCompare? SelfieToDocumentMatch { get; init; }
    }
}