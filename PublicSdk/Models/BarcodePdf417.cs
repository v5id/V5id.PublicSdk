using System.Runtime.CompilerServices;

namespace V5iD.PublicSdk.Models;

using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Text.Json.Serialization;
using V5iD.PublicSdk.Attributes;
using V5iD.PublicSdk.Enums;
using V5iD.PublicSdk.Helpers;

public sealed class BarcodePdf417 : BaseBarcode
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? SourceString { get; init; }

    public char ComplianceIndicator { get; init; }

    public char ElementSeparator { get; init; }

    public char RecordSeparator { get; init; }

    public char SegmentTerminator { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? IssuerIdentificationNumber { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? AamvaVersionNumber { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? JurisdictionVersionNumber { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? NumberEntries { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Collection<SubFileDesignator> SubFileDesignator { get; } = [];

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? FileType { get; init; }

    [Element("DAE")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? DriverNameSuffix { get; init; }

    // can be ‘JR’, ‘SR’, ‘1ST’, ‘2ND’, ‘3RD’, ‘4TH’, ‘5TH’, ‘6TH’, ‘7TH’, ‘8TH’, ‘9TH’, ‘I’, ‘II’, ‘III’, ‘IV’, ‘V’, ‘VI’, ‘VII’, ‘VIII’ or ‘IX’
    [Element("DCU")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? NameSuffix { get; init; }

    [Element("DAF")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? DriverNamePrefix { get; init; }

    [Element("DAJ")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? MailingJurisdictionCode { get; init; }

    [Element("DAK")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? MailingPostalCode { get; init; }

    [Element("DAL")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? ResidenceStreetAddress1 { get; init; }

    [Element("DAM")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? ResidenceStreetAddress2 { get; init; }

    [Element("DAN")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? ResidenceCity { get; init; }

    [Element("DAO")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? ResidenceJurisdictionCode { get; init; }

    [Element("DAP")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? ResidencePostalCode { get; init; }

    [Element("DAR")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? DocumentClassificationCode { get; init; }

    [Element("DAS")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? DocumentRestrictionCode { get; init; }

    [Element("DAT")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? DocumentEndorsementsCode { get; init; }

    [Element("DAU")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? HeightInInches { get; init; }

    [Element("DAV")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? HeightInCentimeters { get; init; }

    [Element("DAW")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? WeightInLbs { get; init; }

    [Element("DAX")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? WeightInKG { get; init; }

    [Element("DAY")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? EyeColor { get; init; }

    [Element("DAZ")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? HairColor { get; init; }

    [Element("DBE")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? IssueTimestamp { get; init; }

    [Element("DBF")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? NumberOfDuplicates { get; init; }

    [Element("DBG")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? MedicalIndicatorCodes { get; init; }

    [Element("DBH")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? OrganDonor { get; init; }

    [Element("DBI")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? NonResidentIndicator { get; init; }

    [Element("DBJ")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? UniqueCustomerIdentifier { get; init; }

    [Element("DBK")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? SocialSecurityNumber { get; init; }

    [Element("DBM")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? DriverSocialSecurityNumber { get; init; }

    [Element("DBL")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? DriverDateOfBirth { get; init; }

    [Element("DBN")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? DriverFullName { get; init; }

    [Element("DBP")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? DriverFirstName { get; init; }

    [Element("DBQ")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? DriverMiddleName { get; init; }

    [Element("DBO")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? DriverLastName { get; init; }

    [Element("DBR")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? DriverSuffix { get; init; }

    [Element("DBS")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? DriverPrefix { get; init; }

    [Element("DCA")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? JurisdictionSpecificVehicleClass { get; init; }

    [Element("DCB")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? JurisdictionSpecificRestrictions { get; init; }

    [Element("DCD")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? JurisdictionSpecificEndorsements { get; init; }

    //0 = up to 31 kg (up to 70 lbs)
    //1 = 32 – 45 kg(71 – 100 lbs)
    //2 = 46 - 59 kg(101 – 130 lbs)
    //3 = 60 - 70 kg(131 – 160 lbs)
    //4 = 71 - 86 kg(161 – 190 lbs)
    //5 = 87 - 100 kg(191 – 220 lbs)
    //6 = 101 - 113 kg(221 – 250 lbs)
    //7 = 114 - 127 kg(251 – 280 lbs)
    //8 = 128 – 145 kg(281 – 320 lbs)
    //9 = 146+ kg(321+ lbs)
    [Element("DCE")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? WeightRange { get; init; }

    [Element("DCF")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? DocumentDiscriminator { get; init; }

    [Element("DCG")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? CountryTerritoryOfIssuance { get; init; }

    [Element("DCH")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? FederalCommercialVehicleCodes { get; init; }

    [Element("DCI")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? PlaceOfBirth { get; init; }

    [Element("DCJ")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? AuditInformation { get; init; }

    [Element("DCK")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? InventoryControlNumber { get; init; }

    [Element("DCL")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? RaceEthnicity { get; init; }

    [Element("DCM")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? StandardVehicleClassification { get; init; }

    [Element("DCN")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? StandardEndorsementCode { get; init; }

    [Element("DCO")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? StandardRestrictionCode { get; init; }

    [Element("DCP")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? JurisdictionVehicleClassification { get; init; }

    [Element("DCQ")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? JurisdictionEndorsementCode { get; init; }

    [Element("DCR")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? JurisdictionRestrictionCode { get; init; }

    // Compliance Type, ‘F’ = fully compliant and ‘N’ = non-compliant.
    [Element("DDA")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? ComplianceType { get; init; }

    [Element("DDB")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? CardRevisionDate { get; init; }

    // Date on which the hazardous material endorsement granted by the document is no longer valid
    [Element("DDC")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? HazMatEndorsementExpiryDate { get; init; }

    [Element("DDD")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? LimitedDurationDocumentIndicator { get; init; }

    // A code that indicates whether a field has been truncated (‘T’), has not been truncated (‘N’), or unknown whether truncated (‘U’).
    [Element("DDE")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? FamilyNameTruncation { get; init; }

    // A code that indicates whether a field has been truncated (‘T’), has not been truncated (‘N’), or unknown whether truncated (‘U’).
    [Element("DDF")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? FirstNameTruncation { get; init; }

    // A code that indicates whether a field has been truncated (‘T’), has not been truncated (‘N’), or unknown whether truncated (‘U’).
    [Element("DDG")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? MiddleNameTruncation { get; init; }

    [Element("DDH")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Under18Until { get; init; }

    [Element("DDI")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Under19Until { get; init; }

    [Element("DDJ")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Under21Until { get; init; }

    // Indicator that the cardholder is an organ donor, can be ‘1’ or ‘0’
    [Element("DDK")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? OrganDonorIndicator { get; init; }

    [Element("PAA")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? PermitClassificationCode { get; init; }

    [Element("PAB")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? PermitExpirationDate { get; init; }

    [Element("PAC")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? PermitIdentifier { get; init; }

    [Element("PAD")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? PermitIssueDate { get; init; }

    [Element("PAE")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? PermitRestrictionCode { get; init; }

    [Element("PAF")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? PermitEndorsementCode { get; init; }

    [Element("ZVA")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? CourtRestrictionCode { get; init; }

    // Indicator that the cardholder is a veteran, can be ‘1’ or ‘0’
    [Element("DDL")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? VeteranIndicator { get; init; }

    // Florida
    [Element("ZFB")]
    [StringLength(24)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? FloridaSpecialRestrictions { get; init; }

    [Element("ZFC")]
    [StringLength(11)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? FloridaSafeDriverIndicator { get; init; }

    [Element("ZFD")]
    [StringLength(2)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? FloridaSexualPredator { get; init; }

    [Element("ZFE")]
    [StringLength(2)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? FloridaSexOffenderStatute { get; init; }

    [Element("ZFF")]
    [StringLength(11)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? FloridaInsulinDependent { get; init; }

    [Element("ZFG")]
    [StringLength(24)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? FloridaDevelopmentalDisability { get; init; }

    [Element("ZFH")]
    [StringLength(20)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? FloridaHearingImpaired { get; init; }

    // (SP=Sportsman, BO=Boater, FW=Freshwater Fishing, SW = Saltwater Fishing, HT=Hunting)
    [Element("ZFI")]
    [StringLength(14)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? FloridaFishWildlifeDesignations { get; init; }

    [Element("ZFJ")]
    [StringLength(10)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? FloridaCustomerNumber { get; init; }

    [Element("ZFA")]
    [StringLength(8)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? FloridaReplacedDate { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public IssuerIdentification? IssuerIdentification { get; init; }

    public Collection<string> Errors { get; } = [];

    public static implicit operator BarcodePdf417Formatted(BarcodePdf417 barcode)
    {
        return ToBarcodePdf417Formatted(barcode);
    }

    public static BarcodePdf417Formatted ToBarcodePdf417Formatted(BarcodePdf417 barcode)
    {
        BarcodePdf417Formatted formattedBarcode = DeepCopyHelper.Copy<BarcodePdf417, BarcodePdf417Formatted>(barcode);
        FormattingHelper.FormatName(formattedBarcode);

        foreach (PropertyInfo property in formattedBarcode.GetType().GetProperties())
        {
            FormattingAttribute? attribute = property.GetCustomAttribute<FormattingAttribute>();
            if (attribute != null && attribute.FormattingType != FormattingType.None)
            {
                if (property.GetValue(formattedBarcode) is string value)
                {
                    try
                    {
                        string formattedValue = value;

                        switch (attribute.FormattingType)
                        {
                            case FormattingType.PostalCode:
                                formattedValue = FormattingHelper.FormatCode(value, formattedBarcode.Errors);
                                break;
                            case FormattingType.Gender:
                                formattedValue = FormattingHelper.FormatGender(value, formattedBarcode.Errors);
                                break;
                            case FormattingType.Weight:
                                formattedValue = FormattingHelper.FormatWeight(value, formattedBarcode.Errors);
                                break;
                        }

                        PropertyInfo? formattedProperty = formattedBarcode.GetType().GetProperty(property.Name);
                        formattedProperty?.SetValue(formattedBarcode, formattedValue);
                    }
                    catch (Exception exception)
                    {
                        formattedBarcode.Errors.Add($"Error formatting {property.Name}: {exception.Message}");
                    }
                }
            }
        }

        return formattedBarcode;
    }
}