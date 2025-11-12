namespace V5id.PublicSdk.Models;

using System;
using V5id.PublicSdk.Enums;

public class Email
{
    public Guid EmailUuid { get; init; }

    public required string EmailAddress { get; init; }
        
    public VerificationProcessingStatus EmailVerificationStatus { get; init; }
        
    public bool EmailRequestSend { get; init; }

    public bool VerificationStarted { get; init; }

    public bool VerificationCompleted { get; init; }
}