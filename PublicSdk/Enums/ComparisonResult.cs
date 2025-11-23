namespace V5iD.PublicSdk.Enums;

using System.Text.Json.Serialization;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum ComparisonResult
{
    None = 0,

    Match = 1,

    CloseMatch = 2,

    UnMatch = 3
}