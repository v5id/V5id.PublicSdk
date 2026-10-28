// © Copyright (c) V5iD, Inc. All rights reserved.
// Licensed under the MIT.

using System.Text.Json.Serialization;

namespace V5iD.PublicSdk.Enums
{
    [JsonConverter(typeof (JsonStringEnumConverter))]
    public enum DocumentKind
    {
        Unknown = 0,
        Passport = 1,
        PassportCard = 2,
        DriverLicense = 3,
        IdCard = 4,
        Other = 5
    }
}
