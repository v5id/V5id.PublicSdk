namespace V5id.PublicSdk.Models;

using System;
using System.Collections.Generic;
using V5id.PublicSdk.Enums;

public class UploadedFile
{
    public Guid UploadedFileUuid { get; init; }

    public string ETag { get; init; } = string.Empty;

    public string VersionId { get; init; } = string.Empty;

    public string FileName { get; init; } = string.Empty;

    public long FileSize { get; init; }

    public string ContainerName { get; init; } = string.Empty;

    public string StorageType { get; init; } = string.Empty;

    public FileType FileType { get; init; }

    public VerificationProcessingStatus? FaceStatusType { get; init; }

    public VerificationProcessingStatus? DocumentStatusType { get; init; }

    public IList<FaceDetail>? FaceDetails { get; init; }

    public IList<SignatureDetail>? SignatureDetails { get; init; }

    public IList<DocumentRecognition>? DocumentRecognitions { get; init; }
        
    public IList<BarcodeDetail>? Barcodes { get; init; }
}