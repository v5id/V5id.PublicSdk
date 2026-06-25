// © Copyright (c) V5iD, Inc. All rights reserved.
// Licensed under the MIT.

namespace V5iD.PublicSdk.Enums;

using System.Text.Json.Serialization;

/// <summary>
/// Classification of a detected face on a document, used to colour its bounding box on the client.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum FaceType
{
    /// <summary>The largest face on the image — the genuine document portrait.</summary>
    LargeFace = 0,

    /// <summary>A much smaller secondary face — the printed "ghost photo" security copy.</summary>
    GhostFace = 1,

    /// <summary>A face that matched the known-image (decoy) collection — a printed decoy, not the holder.</summary>
    KnownFace = 2
}
