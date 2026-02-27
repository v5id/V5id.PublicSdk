// Â© Copyright (c) V5iD, Inc. All rights reserved.
// Licensed under the MIT.

namespace V5iD.PublicSdk.Models
{
    public class CreateWebVerificationWithNotificationRequest
    {
        public string? ReferenceId { get; set; }

        public required string FirstName { get; set; }

        public required string LastName { get; set; }

        public required string Phone { get; set; }
        
        public string? Email { get; set; }

        public bool NotifyByEmailWhenVerificationIsComplete { get; set; }
    }
}
