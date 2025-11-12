namespace V5id.Public.Sdk.Models;

using System;
using Enums;

public class PhoneValidationData
{
    public Guid PhoneValidationDataUuid { get; init; }
    
    public string Carrier { get; init; } = string.Empty;

    public string City { get; init; } = string.Empty;

    public string County { get; init; } = string.Empty;

    public string Country { get; init; } = string.Empty;

    public string CountryCodeIso2 { get; init; } = string.Empty;

    public string PostalCode { get; init; } = string.Empty;

    public string PhoneType { get; init; } = string.Empty;

    public string Timezone { get; init; } = string.Empty;

    public string PhoneNumberE164 { get; init; } = string.Empty;

    public string State { get; init; } = string.Empty;
    
    public PhoneValidationStatus ValidationStatus { get; init; }
}