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
    
    public string? ReferenceId { get; init; }

    public VerificationState State { get; init; }

    public VerificationStatus Status { get; init; }

    public VerificationKind Kind { get; init; }

    public Person? Person { get; init; }
    
    public LivenessVerificationStatus? LivenessVerificationStatus { get; init; }
    
    public DateTimeOffset CreatedDate { get; init; }

    public DateTimeOffset ModifiedDate { get; init; }
    
    public DateTimeOffset? AgreementAcceptedAt { get; init; }

    public bool SupportRequestSend { get; init; }

    public bool AssignedToCurrentUser { get; init; }

    /// <summary>
    /// Name of the support status (e.g. "Open"), never its numeric value. Kept as a string because the
    /// SupportStatus enum lives in V5id.Sdk.Messaging, which already depends on this package.
    /// </summary>
    public string? SupportStatus { get; init; }

    public FaceComparisonSection? FaceComparisonSection { get; init; }

    public IList<SignatureCompare>? SignatureCompareResults { get; init; }

    public Demographic? Demographic { get; init; }

    public IList<UploadedFile> UploadedFiles { get; init; } = [];

    public IEnumerable<OverallAnalysis> OverallAnalysis { get; init; } = [];
    
    public DocumentSummary? DocumentSummary { get; init; }

    public IrAnalysis? IrAnalysis { get; init; }

    public bool IsRefunded { get; init; }

    public RefundReason RefundReason { get; init; }

    public string? RefundExplanation { get; init; }

    public DateTimeOffset? RefundedAt { get; init; }
}