// © Copyright (c) V5iD, Inc. All rights reserved.
// Licensed under the MIT.

namespace V5iD.PublicSdk.Models;

using System.Text.Json.Serialization;
using V5iD.PublicSdk.Enums;

public class IssuerIdentification
{
    public string Issuer {  get; set; } = string.Empty;
 
    public string Jurisdiction { get; set; } = string.Empty;

    public string Abbreviation { get; set; } = string.Empty;

    [JsonConverter(typeof(JsonStringEnumConverter<CountryType>))]
    public CountryType Country { get; set; } = CountryType.None;
}