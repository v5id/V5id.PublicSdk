// © Copyright (c) V5iD, Inc. All rights reserved.
// Licensed under the MIT.

using System.Text.Json.Serialization;

namespace V5iD.PublicSdk.Enums
{
    /// <summary>
    /// Lifecycle of the selfie-to-document face comparison — whether it could be performed at all —
    /// independent of how well the faces matched. The match quality itself is carried separately by
    /// <see cref="Models.FaceComparisonSection.SelfieToDocumentMatch"/>. Surfaced in the summary as the
    /// "Face To Document Compare" status.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum FaceToDocumentCompareState
    {
        /// <summary>
        /// The comparison was not performed: no face on the document, no selfie, or the face step was
        /// skipped.
        /// </summary>
        NotPerformed,

        /// <summary>Face processing has not reached a terminal state yet.</summary>
        Processing,

        /// <summary>
        /// The selfie-to-document comparison produced a result —
        /// <see cref="Models.FaceComparisonSection.SelfieToDocumentMatch"/> is set.
        /// </summary>
        Completed,

        /// <summary>Face processing finished but produced no usable face — the comparison could not complete.</summary>
        Failed
    }
}
