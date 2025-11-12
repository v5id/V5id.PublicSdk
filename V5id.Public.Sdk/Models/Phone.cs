namespace V5id.Public.Sdk.Models;

using Enums;

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