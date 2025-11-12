namespace V5id.PublicSdk.Enums;

using System.Text.Json.Serialization;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum OverallMismatchType
{
    None = 0,
    
    Demographic = 1,
    
    Document = 2
}