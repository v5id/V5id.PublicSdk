namespace V5id.PublicSdk.Models;

using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Text.Json.Serialization;
using V5id.PublicSdk.Attributes;
using V5id.PublicSdk.Enums;
using V5id.PublicSdk.Helpers;

internal sealed class BarcodePdf417 : BaseBarcode
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    internal string? SourceString { get; init; }

    internal char ComplianceIndicator { get; init; }

    internal char ElementSeparator { get; init; }

    internal char RecordSeparator { get; init; }

    internal char SegmentTerminator { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    internal string? IssuerIdentificationNumber { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    internal string? AamvaVersionNumber { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    internal string? JurisdictionVersionNumber { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    internal string? NumberEntries { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    internal Collection<SubFileDesignator> SubFileDesignator { get; } = [];

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    internal string? FileType { get; init; }

    [Element("DAE")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    internal string? DriverNameSuffix { get; init; }

    // can be ‘JR’, ‘SR’, ‘1ST’, ‘2ND’, ‘3RD’, ‘4TH’, ‘5TH’, ‘6TH’, ‘7TH’, ‘8TH’, ‘9TH’, ‘I’, ‘II’, ‘III’, ‘IV’, ‘V’, ‘VI’, ‘VII’, ‘VIII’ or ‘IX’
    [Element("DCU")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    internal string? NameSuffix { get; init; }

    [Element("DAF")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    internal string? DriverNamePrefix { get; init; }

    [Element("DAJ")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    internal string? MailingJurisdictionCode { get; init; }

    [Element("DAK")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    internal string? MailingPostalCode { get; init; }

    [Element("DAL")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    internal string? ResidenceStreetAddress1 { get; init; }

    [Element("DAM")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    internal string? ResidenceStreetAddress2 { get; init; }

    [Element("DAN")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    internal string? ResidenceCity { get; init; }

    [Element("DAO")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    internal string? ResidenceJurisdictionCode { get; init; }

    [Element("DAP")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    internal string? ResidencePostalCode { get; init; }

    [Element("DAR")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    internal string? DocumentClassificationCode { get; init; }

    [Element("DAS")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    internal string? DocumentRestrictionCode { get; init; }

    [Element("DAT")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    internal string? DocumentEndorsementsCode { get; init; }

    [Element("DAU")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    internal string? HeightInInches { get; init; }

    [Element("DAV")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    internal string? HeightInCentimeters { get; init; }

    [Element("DAW")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    internal string? WeightInLbs { get; init; }

    [Element("DAX")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    internal string? WeightInKG { get; init; }

    [Element("DAY")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    internal string? EyeColor { get; init; }

    [Element("DAZ")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    internal string? HairColor { get; init; }

    [Element("DBE")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    internal string? IssueTimestamp { get; init; }

    [Element("DBF")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    internal string? NumberOfDuplicates { get; init; }

    [Element("DBG")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    internal string? MedicalIndicatorCodes { get; init; }

    [Element("DBH")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    internal string? OrganDonor { get; init; }

    [Element("DBI")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    internal string? NonResidentIndicator { get; init; }

    [Element("DBJ")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    internal string? UniqueCustomerIdentifier { get; init; }

    [Element("DBK")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    internal string? SocialSecurityNumber { get; init; }

    [Element("DBM")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    internal string? DriverSocialSecurityNumber { get; init; }

    [Element("DBL")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    internal string? DriverDateOfBirth { get; init; }

    [Element("DBN")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    internal string? DriverFullName { get; init; }

    [Element("DBP")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    internal string? DriverFirstName { get; init; }

    [Element("DBQ")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    internal string? DriverMiddleName { get; init; }

    [Element("DBO")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    internal string? DriverLastName { get; init; }

    [Element("DBR")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    internal string? DriverSuffix { get; init; }

    [Element("DBS")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    internal string? DriverPrefix { get; init; }

    [Element("DCA")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    internal string? JurisdictionSpecificVehicleClass { get; init; }

    [Element("DCB")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    internal string? JurisdictionSpecificRestrictions { get; init; }

    [Element("DCD")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    internal string? JurisdictionSpecificEndorsements { get; init; }

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
    internal string? WeightRange { get; init; }

    [Element("DCF")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    internal string? DocumentDiscriminator { get; init; }

    [Element("DCG")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    internal string? CountryTerritoryOfIssuance { get; init; }

    [Element("DCH")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    internal string? FederalCommercialVehicleCodes { get; init; }

    [Element("DCI")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    internal string? PlaceOfBirth { get; init; }

    [Element("DCJ")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    internal string? AuditInformation { get; init; }

    [Element("DCK")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    internal string? InventoryControlNumber { get; init; }

    [Element("DCL")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    internal string? RaceEthnicity { get; init; }

    [Element("DCM")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    internal string? StandardVehicleClassification { get; init; }

    [Element("DCN")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    internal string? StandardEndorsementCode { get; init; }

    [Element("DCO")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    internal string? StandardRestrictionCode { get; init; }

    [Element("DCP")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    internal string? JurisdictionVehicleClassification { get; init; }

    [Element("DCQ")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    internal string? JurisdictionEndorsementCode { get; init; }

    [Element("DCR")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    internal string? JurisdictionRestrictionCode { get; init; }

    // Compliance Type, ‘F’ = fully compliant and ‘N’ = non-compliant.
    [Element("DDA")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    internal string? ComplianceType { get; init; }

    [Element("DDB")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    internal string? CardRevisionDate { get; init; }

    // Date on which the hazardous material endorsement granted by the document is no longer valid
    [Element("DDC")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    internal string? HazMatEndorsementExpiryDate { get; init; }

    [Element("DDD")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    internal string? LimitedDurationDocumentIndicator { get; init; }

    // A code that indicates whether a field has been truncated (‘T’), has not been truncated (‘N’), or unknown whether truncated (‘U’).
    [Element("DDE")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    internal string? FamilyNameTruncation { get; init; }

    // A code that indicates whether a field has been truncated (‘T’), has not been truncated (‘N’), or unknown whether truncated (‘U’).
    [Element("DDF")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    internal string? FirstNameTruncation { get; init; }

    // A code that indicates whether a field has been truncated (‘T’), has not been truncated (‘N’), or unknown whether truncated (‘U’).
    [Element("DDG")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    internal string? MiddleNameTruncation { get; init; }

    [Element("DDH")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    internal string? Under18Until { get; init; }

    [Element("DDI")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    internal string? Under19Until { get; init; }

    [Element("DDJ")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    internal string? Under21Until { get; init; }

    // Indicator that the cardholder is an organ donor, can be ‘1’ or ‘0’
    [Element("DDK")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    internal string? OrganDonorIndicator { get; init; }

    [Element("PAA")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    internal string? PermitClassificationCode { get; init; }

    [Element("PAB")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    internal string? PermitExpirationDate { get; init; }

    [Element("PAC")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    internal string? PermitIdentifier { get; init; }

    [Element("PAD")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    internal string? PermitIssueDate { get; init; }

    [Element("PAE")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    internal string? PermitRestrictionCode { get; init; }

    [Element("PAF")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    internal string? PermitEndorsementCode { get; init; }

    [Element("ZVA")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    internal string? CourtRestrictionCode { get; init; }

    // Indicator that the cardholder is a veteran, can be ‘1’ or ‘0’
    [Element("DDL")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    internal string? VeteranIndicator { get; init; }

    // Florida
    [Element("ZFB")]
    [StringLength(24)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    internal string? FloridaSpecialRestrictions { get; init; }

    [Element("ZFC")]
    [StringLength(11)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    internal string? FloridaSafeDriverIndicator { get; init; }

    [Element("ZFD")]
    [StringLength(2)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    internal string? FloridaSexualPredator { get; init; }

    [Element("ZFE")]
    [StringLength(2)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    internal string? FloridaSexOffenderStatute { get; init; }

    [Element("ZFF")]
    [StringLength(11)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    internal string? FloridaInsulinDependent { get; init; }

    [Element("ZFG")]
    [StringLength(24)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    internal string? FloridaDevelopmentalDisability { get; init; }

    [Element("ZFH")]
    [StringLength(20)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    internal string? FloridaHearingImpaired { get; init; }

    // (SP=Sportsman, BO=Boater, FW=Freshwater Fishing, SW = Saltwater Fishing, HT=Hunting)
    [Element("ZFI")]
    [StringLength(14)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    internal string? FloridaFishWildlifeDesignations { get; init; }

    [Element("ZFJ")]
    [StringLength(10)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    internal string? FloridaCustomerNumber { get; init; }

    [Element("ZFA")]
    [StringLength(8)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    internal string? FloridaReplacedDate { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    internal IssuerIdentification? IssuerIdentification { get; init; }

    internal Collection<string> Errors { get; } = [];

    public static implicit operator BarcodePdf417Formatted(BarcodePdf417 barcode)
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