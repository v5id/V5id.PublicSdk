namespace V5id.Public.Sdk.Models;

using System.Text.Json.Serialization;
using Enums;

public class IssuerIdentification
{
    public string Issuer {  get; internal set; } = string.Empty;
 
    public string Jurisdiction { get; internal set; } = string.Empty;

    public string Abbreviation { get; internal set; } = string.Empty;

    [JsonConverter(typeof(JsonStringEnumConverter<CountryType>))]
    public CountryType Country { get; internal set; } = CountryType.None;
}