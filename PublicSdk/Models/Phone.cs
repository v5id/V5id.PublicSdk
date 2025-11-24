// © Copyright (c) V5iD, Inc. All rights reserved.
// Licensed under the MIT.

namespace V5iD.PublicSdk.Models;

using System;
using System.Collections.Generic;
using V5iD.PublicSdk.Enums;

public class Phone
{
    public Guid PhoneUuid { get; init; }

    public required string PhoneNumber { get; init; }

    public string? Extension { get; init; }

    public VerificationProcessingStatus PhoneVerificationStatus { get; init; }
        
    public bool PhoneRequestSend { get; init; }

    public bool VerificationStarted { get; init; }

    public bool VerificationCompleted { get; init; }
        
    public ICollection<PhoneValidationData>? PhoneValidationData { get; init; }
}