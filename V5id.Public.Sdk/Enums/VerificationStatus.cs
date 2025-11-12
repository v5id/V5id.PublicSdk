namespace V5id.Public.Sdk.Enums;

using System.Text.Json.Serialization;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum VerificationStatus
{
    None = 0,
    Created = 1,
    Active = 2,
    Completed = 3,
    Inactive = 4,
    Disabled = 5,
    ToBeDeleted = 6,
    Deleted = 7,
}