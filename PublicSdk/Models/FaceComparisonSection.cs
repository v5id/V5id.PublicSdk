// © Copyright (c) V5iD, Inc. All rights reserved.
// Licensed under the MIT.

using System.Collections.Generic;
using V5iD.PublicSdk.Enums;

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

        /// <summary>
        /// Lifecycle of the selfie-to-document face comparison — whether it could be performed at all —
        /// surfaced in the summary as "Face To Document Compare". Distinct from
        /// <see cref="SelfieToDocumentMatch"/>, which carries the match quality. Null on legacy payloads
        /// that predate this field.
        /// </summary>
        public FaceToDocumentCompareState? State { get; init; }
    }
}