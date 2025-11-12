namespace V5id.Public.Sdk.Models;

using System;
using Enums;

public class Email
{
    public Guid EmailUuid { get; init; }

    public required string EmailAddress { get; init; }
        
    public VerificationProcessingStatus EmailVerificationStatus { get; init; }
        
    public bool EmailRequestSend { get; init; }

    public bool VerificationStarted { get; init; }

    public bool VerificationCompleted { get; init; }
}