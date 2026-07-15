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

    // "Item is not present in the document" (e.g. no face on the document), as opposed to Error
    // ("something went wrong"). Split into Error/Success so the client knows whether the absence
    // actually failed the verification:
    //   NotDetectedError   — absent AND it caused the check to fail.
    //   NotDetectedSuccess — absent but it did NOT fail the verification (benign).
    // Appended at the end so existing persisted values keep their meaning.
    // WARNING: this enum is aggregated by severity via Math.Max in the recognition pipeline
    // (Document.Api DocumentRecognitionService, CustomerService document summary). These values have
    // the highest numbers and would win any Max() and mask a real Error. Only use them in display-only
    // items that never flow into those Max() aggregations.
    NotDetectedError = 4,
    NotDetectedSuccess = 5
}