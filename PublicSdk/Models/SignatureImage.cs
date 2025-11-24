// © Copyright (c) V5iD, Inc. All right reserved.
// Licensed under the MIT.

namespace V5iD.PublicSdk.Models;

using V5iD.PublicSdk.Enums;

public class SignatureImage
{
    public string FileName { get; init; } = string.Empty;

    public string ContainerName { get; init; } = string.Empty;

    public FileType FileType { get; init; }
}