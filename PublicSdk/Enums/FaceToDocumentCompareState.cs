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
        /// <summary>No face was detected on the document, so there was nothing to compare against.</summary>
        NotPerformed,

        /// <summary>Face processing has not reached a terminal state yet.</summary>
        Processing,

        /// <summary>A usable document face was found, so the comparison could be performed.</summary>
        Completed,

        /// <summary>Face processing finished but produced no usable face — the comparison could not complete.</summary>
        Failed
    }
}
