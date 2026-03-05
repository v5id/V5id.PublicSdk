// © Copyright (c) V5iD, Inc. All rights reserved.
// Licensed under the MIT.

using System.ComponentModel;
using System.Text.Json.Serialization;

namespace V5iD.PublicSdk.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum DocumentConsistencyAnalysis
    {
        None = 0,

        [Description("Consistency issue date")]
        DocumentIssueDate,

        [Description("Consistency document number")]
        DocumentNumber,

        [Description("Consistency date of expiration")]
        ExpirationDate,

        [Description("Consistency first name")]
        FirstName,

        [Description("Consistency middle name")]
        MiddleName,

        [Description("Consistency last name")]
        LastName,

        [Description("Consistency birthdate")]
        DateOfBirth,

        [Description("Consistency gender")]
        Gender,

        [Description("Consistency document type")]
        DocumentType,

        [Description("Consistency document issuer")]
        DocumentIssuer,

        [Description("Consistency country")]
        DocumentCountry,

        [Description("Consistency State")]
        DocumentState,

        [Description("Consistency nationality")]
        Nationality,

        [Description("Consistency document discriminator")]
        DocumentDiscriminator,

        [Description("Consistency address")]
        Address,
    }
}