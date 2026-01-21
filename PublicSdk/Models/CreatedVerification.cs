// © Copyright (c) V5iD, Inc. All rights reserved.
// Licensed under the MIT.

using System;
using System.Collections.Generic;
using V5iD.PublicSdk.Enums;

namespace V5iD.PublicSdk.Models
{
    public class CreatedVerification
    {
        public required string VerificationUuid { get; set; }

        public required bool IsWaitForStartVerification { get; set; }

        public IEnumerable<IntegrationScope> IntegrationScopes { get; set; } = [];
    }
}