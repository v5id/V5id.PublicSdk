namespace V5id.Public.Sdk.Enums;

using System.Text.Json.Serialization;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum DocumentRecognitionStatus
{
    Unrecognized = 0,
    Successful = 1,
    Warning = 2,
    Error = 3
}