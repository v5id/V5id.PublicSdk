// © Copyright (c) V5iD, Inc. All right reserved.
// Licensed under the MIT.

using System;
using V5iD.PublicSdk.Enums;

namespace V5iD.PublicSdk.Models
{
    public class NewUploadedFile
    {
        public string ETag { get; set; } = string.Empty;

        public string VersionId { get; set; } = string.Empty;

        public string FileName { get; set; } = string.Empty;

        public long FileSize { get; set; }

        public string ContainerName { get; set; } = string.Empty;

        public string StorageType { get; set; } = string.Empty;

        public FileType FileType { get; set; }

        public string Key { get; set; } = string.Empty;

        public string FileUrl { get; set; } = string.Empty;

        public Guid UploadFileUuid { get; set; }
    }
}