namespace V5iD.PublicSdk.Models;

using System.Text.Json.Serialization;

public class SubFileDesignator
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? SubFileType { get; internal set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Offset { get; internal set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Length { get; internal set; }
}