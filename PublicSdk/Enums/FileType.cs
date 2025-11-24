// © Copyright (c) V5iD, Inc. All right reserved.
// Licensed under the MIT.

namespace V5iD.PublicSdk.Enums;

using System.Text.Json.Serialization;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum FileType
{
    None = 0,

    FaceImage = 1,

    FaceVideo = 2,

    DocumentFront = 3,

    DocumentBack = 4,

    SignatureImage = 5,

    ClearedUploadedSignature = 6,

    ClearedIdSignature = 7,
    
    CutIdSignature = 8,
    
    CutUploadedSignature = 9,
    
    IrDocumentFront = 10,
    
    IrDocumentBack = 11,
    
    UvDocumentFront = 12,
    
    UvDocumentBack = 13,
    
    Agreement = 14
}