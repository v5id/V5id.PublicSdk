namespace V5iD.PublicSdk.Enums;

using System.Text.Json.Serialization;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum PhoneValidationStatus
{
    None = 0,
    Success = 1,
    Warning = 2,
    Error = 3
}