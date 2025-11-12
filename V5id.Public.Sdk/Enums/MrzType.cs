namespace V5id.Public.Sdk.Enums;

using System.Text.Json.Serialization;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum MrzType
{
    Unknown = 0, 
    TD1 = 1, 
    TD2 = 2, 
    TD3 = 3
}