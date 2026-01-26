// © Copyright (c) V5iD, Inc. All rights reserved.
// Licensed under the MIT.

using V5iD.PublicSdk.Enums;

namespace V5iD.PublicSdk.Models
{
    public class LivenessVerificationStatus
    {
        public float? Confidence { get; init; }
        
        public LivenessStatus Status { get; init; }
    }
}