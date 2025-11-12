namespace V5id.Public.Sdk.Enums;

using System.Text.Json.Serialization;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum DocumentFieldType
{
    None = 0,

    ExpirationDate = 1,

    FirstName = 2,

    LastName = 3,

    MiddleName = 4,

    Sex = 5,

    DateOfBirth = 6,

    Nationality = 7,

    Country = 8,

    DocumentNumber = 9,

    Street = 10,

    City = 11,

    State = 12,
    
    PostalCode = 13,
    
    DocumentDiscriminator = 14
}