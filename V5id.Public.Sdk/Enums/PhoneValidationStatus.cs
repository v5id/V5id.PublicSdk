namespace V5id.Public.Sdk.Enums;

using System.Runtime.InteropServices.JavaScript;
using System.Text.Json.Serialization;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum PhoneValidationStatus
{
    None = 0,
    Success = 1,
    Warning = 2,
    Error = 3
}