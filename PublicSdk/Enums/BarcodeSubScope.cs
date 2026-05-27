// © Copyright (c) V5iD, Inc. All rights reserved.
// Licensed under the MIT.

using System.Text.Json.Serialization;

namespace V5iD.PublicSdk.Enums
{
    [JsonConverter(typeof (JsonStringEnumConverter))]
    public enum BarcodeSubScope
    {
        None = 0,
        FullName = 1,
        DlExpirationDate = 2,
        Age = 3,
        DocumentIdNumber = 4,
        Address = 5
    }
}
