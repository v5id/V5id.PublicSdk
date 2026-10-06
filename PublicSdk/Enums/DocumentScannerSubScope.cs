// © Copyright (c) V5iD, Inc. All rights reserved.
// Licensed under the MIT.

using System.Text.Json.Serialization;

namespace V5iD.PublicSdk.Enums
{
    [JsonConverter(typeof (JsonStringEnumConverter))]
    public enum DocumentScannerSubScope
    {
        None = 0,
        Image = 1,
        DateOfBirth = 2,
        IssueDate = 3,
        DocumentType = 4
    }
}
