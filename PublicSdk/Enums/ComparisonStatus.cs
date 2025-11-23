namespace V5iD.PublicSdk.Enums;

using System.Text.Json.Serialization;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum ComparisonStatus
{
    None = 0,

    Success = 1,

    Alert = 2,

    Failed = 3
}