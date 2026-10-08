// © Copyright (c) V5iD, Inc. All rights reserved.
// Licensed under the MIT.

using System.Text.Json.Serialization;

namespace V5iD.PublicSdk.Enums
{
    [JsonConverter(typeof (JsonStringEnumConverter))]
    public enum DocumentScannerSubScope
    {
        None = 0,

        /// <summary>Legacy alias for <see cref="FrontImage"/> + <see cref="BackImage"/>; stored on older integrations.</summary>
        Image = 1,
        DateOfBirth = 2,
        IssueDate = 3,
        DocumentType = 4,
        FullName = 5,
        ExpirationDate = 6,
        Age = 7,
        DocumentIdNumber = 8,
        Address = 9,
        Gender = 10,
        Nationality = 11,
        FrontImage = 12,
        BackImage = 13,
        SelfieImage = 14
    }
}
