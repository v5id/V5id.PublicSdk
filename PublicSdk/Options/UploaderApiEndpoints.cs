// © Copyright (c) V5iD, Inc. All rights reserved.
// Licensed under the MIT.

namespace V5iD.PublicSdk.Options
{
    internal static class UploaderApiEndpoints
    {
        internal static string UploadFront { get; set; } = "upload/front/{verificationUuid}";
        
        internal static string UploadBack { get; set; } = "upload/back/{verificationUuid}";
        
        internal static string UploadFace { get; set; } = "upload/face/{verificationUuid}";
    }
}