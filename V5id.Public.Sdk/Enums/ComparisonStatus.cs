namespace V5id.Public.Sdk.Enums;

using System.Text.Json.Serialization;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum ComparisonStatus
{
    None = 0,

    Success = 1,

    Alert = 2,

    Failed = 3
}