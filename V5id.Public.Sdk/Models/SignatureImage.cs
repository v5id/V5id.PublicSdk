namespace V5id.Public.Sdk.Models;

using Enums;

public class SignatureImage
{
    public string FileName { get; init; } = string.Empty;

    public string ContainerName { get; init; } = string.Empty;

    public FileType FileType { get; init; }
}