// © Copyright (c) V5iD, Inc. All rights reserved.
// Licensed under the MIT.

namespace V5iD.PublicSdk.Models;

using System;
using V5iD.PublicSdk.Enums;

public class Email
{
    public Guid EmailUuid { get; init; }

    public required string EmailAddress { get; init; }
        
    public VerificationProcessingStatus EmailVerificationStatus { get; init; }
        
    public bool EmailRequestSend { get; init; }

    public bool VerificationStarted { get; init; }

    public bool VerificationCompleted { get; init; }
}