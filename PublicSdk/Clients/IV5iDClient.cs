// © Copyright (c) V5iD, Inc. All rights reserved.
// Licensed under the MIT.

using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using V5iD.PublicSdk.Enums;
using V5iD.PublicSdk.Models;

namespace V5iD.PublicSdk.Clients
{
    public interface IV5iDClient : IAsyncDisposable
    {
        Task<OperationResult<CreatedVerification>> CreateVerificationAsync(
            CancellationToken cancellationToken = default);

        Task<OperationResult<Verification>> GetVerificationAsync(
            CancellationToken cancellationToken = default);
        
        Task<OperationResult<NewUploadedFile>> UploadFileAsync(FileType fileType,
            string verificationUuid,
            Stream fileStream,
            string fileName,
            string contentType = "application/octet-stream",
            bool leaveOpen = false,
            CancellationToken cancellationToken = default);

        Task<OperationResult<CreatedWebVerification>> CreateWebVerificationAsync(
            string? referenceId = null,
            CancellationToken cancellationToken = default);
    }
}