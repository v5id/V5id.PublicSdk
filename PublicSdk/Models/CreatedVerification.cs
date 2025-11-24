// © Copyright (c) V5iD, Inc. All right reserved.
// Licensed under the MIT.

using System;
using System.Collections.Generic;

namespace V5iD.PublicSdk.Models
{
    public class CreatedVerification
    {
        public required string VerificationUuid { get; set; }

        public required bool IsWaitForStartVerification { get; set; }

        public IEnumerable<IntegrationScope> IntegrationScopes { get; set; } = [];
    }
}