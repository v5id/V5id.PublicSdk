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

    public DeviceVerificationImages? Images { get; init; }
}

public class DeviceVerificationImages
{
    public DeviceVerificationImage? Front { get; init; }

    public DeviceVerificationImage? Back { get; init; }
}

public class DeviceVerificationImage
{
    public string FileName { get; init; } = string.Empty;

    public FileType FileType { get; init; }
}
