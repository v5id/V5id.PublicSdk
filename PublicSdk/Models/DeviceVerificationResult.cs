// © Copyright (c) V5iD, Inc. All rights reserved.
// Licensed under the MIT.

namespace V5iD.PublicSdk.Models;

using System.Collections.Generic;
using V5iD.PublicSdk.Enums;

public class DeviceVerificationResult
{
    public VerificationStatus Status { get; init; }

    public IList<string> FailedSteps { get; init; } = [];

    public string? DateOfBirth { get; init; }

    public string? IssueDate { get; init; }

    public DocumentKind? DocumentType { get; init; }

    public string? FirstName { get; init; }

    public string? MiddleName { get; init; }

    public string? LastName { get; init; }

    public string? ExpirationDate { get; init; }

    /// <summary>Whole years on the day of the request, computed from the date of birth.</summary>
    public int? Age { get; init; }

    public string? DocumentNumber { get; init; }

    public DeviceVerificationAddress? Address { get; init; }

    /// <summary>M, F or N, the vocabulary of the standalone barcode and MRZ responses.</summary>
    public string? Gender { get; init; }

    /// <summary>The MRZ nationality; a driver licence has none, so its PDF417 country of issuance stands in.</summary>
    public string? Nationality { get; init; }

    public DeviceVerificationImages? Images { get; init; }
}

public class DeviceVerificationAddress
{
    public string? StreetAddress { get; init; }

    public string? City { get; init; }

    public string? RegionCode { get; init; }

    public string? PostalCode { get; init; }

    public string? CountryCode { get; init; }
}

public class DeviceVerificationImages
{
    public DeviceVerificationImage? Front { get; init; }

    public DeviceVerificationImage? Back { get; init; }

    public DeviceVerificationImage? Selfie { get; init; }
}

public class DeviceVerificationImage
{
    public FileType FileType { get; init; }

    public string ContentType { get; init; } = string.Empty;

    /// <summary>The stored image bytes, base64-encoded.</summary>
    public string Base64 { get; init; } = string.Empty;
}
