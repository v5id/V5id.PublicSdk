namespace V5id.PublicSdk.Enums;

using System.Text.Json.Serialization;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum VerificationProcessingStatus
{
    None = 0,

    Created = 1,

    Started = 2,

    Failed = 3,

    Expired = 4,

    MessageSent = 5,

    Verified = 6,
}