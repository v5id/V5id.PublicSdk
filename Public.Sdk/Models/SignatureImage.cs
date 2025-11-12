namespace V5id.PublicSdk.Models;

using V5id.PublicSdk.Enums;

public class SignatureImage
{
    public string FileName { get; init; } = string.Empty;

    public string ContainerName { get; init; } = string.Empty;

    public FileType FileType { get; init; }
}