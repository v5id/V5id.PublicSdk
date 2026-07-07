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
        /// Process state of the selfie-to-document face comparison (ran / running / could not run /
        /// not applicable), independent of the <see cref="SelfieToDocumentMatch"/> similarity score.
        /// Surfaced in the summary as the "Face To Document Compare" status.
        /// </summary>
        public FaceToDocumentCompareStatus FaceToDocumentCompareStatus { get; init; }
    }
}