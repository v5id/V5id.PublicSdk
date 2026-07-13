// © Copyright (c) V5iD, Inc. All rights reserved.
// Licensed under the MIT.

namespace V5iD.PublicSdk.Enums;

using System.Text.Json.Serialization;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum DocumentRecognitionStatus
{
    Unrecognized = 0,
    Successful = 1,
    Warning = 2,
    Error = 3,

    // "Item is present in the flow but was not found in the document" (e.g. no face on the document),
    // as opposed to Error ("something went wrong"). Appended at the end so existing persisted values
    // keep their meaning.
    // WARNING: this enum is aggregated by severity via Math.Max in the recognition pipeline
    // (Document.Api DocumentRecognitionService, CustomerService document summary). Because NotDetected
    // has the highest numeric value it would win any Max() and mask a real Error. Only use it in
    // display-only items that never flow into those Max() aggregations.
    NotDetected = 4
}