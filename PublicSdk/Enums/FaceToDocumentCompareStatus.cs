// © Copyright (c) V5iD, Inc. All rights reserved.
// Licensed under the MIT.

namespace V5iD.PublicSdk.Enums;

using System.Text.Json.Serialization;

/// <summary>
/// Process state of the selfie-to-document face comparison, independent of the similarity score.
/// Surfaced in the verification summary as the "Face To Document Compare" status.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum FaceToDocumentCompareStatus
{
    /// <summary>No face (selfie) was loaded, so there was nothing to compare against the document.</summary>
    NotPerformed = 0,

    /// <summary>A face was loaded and the selfie-to-document comparison is still running.</summary>
    Processing = 1,

    /// <summary>The selfie-to-document comparison ran and produced a result.</summary>
    Completed = 2,

    /// <summary>A face was loaded but the comparison could not complete (e.g. no face found in the document).</summary>
    Failed = 3,
}
