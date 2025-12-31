// © Copyright (c) V5iD, Inc. All rights reserved.
// Licensed under the MIT.

namespace V5iD.PublicSdk.Models;

using System;
using System.Collections.Generic;
using V5iD.PublicSdk.Enums;

public class Verification
{
    public string VerificationUuid { get; init; } = string.Empty;

    public string ClientId { get; init; } = string.Empty;

    public VerificationStatus VerificationStatus { get; init; }
    
    public VerificationOverallStatus VerificationOverallStatus { get; init; }
    
    public int? Age { get; init; }
    
    public DateTimeOffset CreatedDate { get; init; }

    public DateTimeOffset ModifiedDate { get; init; }

    public bool SupportRequestSend { get; init; }

    public IList<FaceCompare>? FaceCompareResults { get; init; }

    public IList<SignatureCompare>? SignatureCompareResults { get; init; }

    public Demographic? Demographic { get; init; }

    public IList<UploadedFile> UploadedFiles { get; init; } = [];

    public IEnumerable<OverallAnalysis> OverallAnalysis { get; init; } = [];
}