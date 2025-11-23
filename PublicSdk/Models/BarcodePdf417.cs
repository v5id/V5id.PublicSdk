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
    public string? SourceString { get; set; }

    public char ComplianceIndicator { get; set; }

    public char ElementSeparator { get; set; }

    public char RecordSeparator { get; set; }

    public char SegmentTerminator { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? IssuerIdentificationNumber { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? AamvaVersionNumber { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? JurisdictionVersionNumber { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? NumberEntries { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Collection<SubFileDesignator> SubFileDesignator { get; } = [];

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? FileType { get; set; }

    [Element("DAE")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? DriverNameSuffix { get; set; }

    // can be ‘JR’, ‘SR’, ‘1ST’, ‘2ND’, ‘3RD’, ‘4TH’, ‘5TH’, ‘6TH’, ‘7TH’, ‘8TH’, ‘9TH’, ‘I’, ‘II’, ‘III’, ‘IV’, ‘V’, ‘VI’, ‘VII’, ‘VIII’ or ‘IX’
    [Element("DCU")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? NameSuffix { get; set; }

    [Element("DAF")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? DriverNamePrefix { get; set; }

    [Element("DAJ")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? MailingJurisdictionCode { get; set; }

    [Element("DAK")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? MailingPostalCode { get; set; }

    [Element("DAL")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? ResidenceStreetAddress1 { get; set; }

    [Element("DAM")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? ResidenceStreetAddress2 { get; set; }

    [Element("DAN")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? ResidenceCity { get; set; }

    [Element("DAO")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? ResidenceJurisdictionCode { get; set; }

    [Element("DAP")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? ResidencePostalCode { get; set; }

    [Element("DAR")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? DocumentClassificationCode { get; set; }

    [Element("DAS")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? DocumentRestrictionCode { get; set; }

    [Element("DAT")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? DocumentEndorsementsCode { get; set; }

    [Element("DAU")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? HeightInInches { get; set; }

    [Element("DAV")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? HeightInCentimeters { get; set; }

    [Element("DAW")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? WeightInLbs { get; set; }

    [Element("DAX")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? WeightInKG { get; set; }

    [Element("DAY")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? EyeColor { get; set; }

    [Element("DAZ")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? HairColor { get; set; }

    [Element("DBE")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? IssueTimestamp { get; set; }

    [Element("DBF")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? NumberOfDuplicates { get; set; }

    [Element("DBG")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? MedicalIndicatorCodes { get; set; }

    [Element("DBH")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? OrganDonor { get; set; }

    [Element("DBI")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? NonResidentIndicator { get; set; }

    [Element("DBJ")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? UniqueCustomerIdentifier { get; set; }

    [Element("DBK")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? SocialSecurityNumber { get; set; }

    [Element("DBM")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? DriverSocialSecurityNumber { get; set; }

    [Element("DBL")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? DriverDateOfBirth { get; set; }

    [Element("DBN")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? DriverFullName { get; set; }

    [Element("DBP")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? DriverFirstName { get; set; }

    [Element("DBQ")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? DriverMiddleName { get; set; }

    [Element("DBO")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? DriverLastName { get; set; }

    [Element("DBR")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? DriverSuffix { get; set; }

    [Element("DBS")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? DriverPrefix { get; set; }

    [Element("DCA")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? JurisdictionSpecificVehicleClass { get; set; }

    [Element("DCB")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? JurisdictionSpecificRestrictions { get; set; }

    [Element("DCD")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? JurisdictionSpecificEndorsements { get; set; }

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
    public string? WeightRange { get; set; }

    [Element("DCF")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? DocumentDiscriminator { get; set; }

    [Element("DCG")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? CountryTerritoryOfIssuance { get; set; }

    [Element("DCH")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? FederalCommercialVehicleCodes { get; set; }

    [Element("DCI")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? PlaceOfBirth { get; set; }

    [Element("DCJ")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? AuditInformation { get; set; }

    [Element("DCK")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? InventoryControlNumber { get; set; }

    [Element("DCL")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? RaceEthnicity { get; set; }

    [Element("DCM")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? StandardVehicleClassification { get; set; }

    [Element("DCN")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? StandardEndorsementCode { get; set; }

    [Element("DCO")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? StandardRestrictionCode { get; set; }

    [Element("DCP")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? JurisdictionVehicleClassification { get; set; }

    [Element("DCQ")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? JurisdictionEndorsementCode { get; set; }

    [Element("DCR")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? JurisdictionRestrictionCode { get; set; }

    // Compliance Type, ‘F’ = fully compliant and ‘N’ = non-compliant.
    [Element("DDA")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? ComplianceType { get; set; }

    [Element("DDB")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? CardRevisionDate { get; set; }

    // Date on which the hazardous material endorsement granted by the document is no longer valid
    [Element("DDC")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? HazMatEndorsementExpiryDate { get; set; }

    [Element("DDD")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? LimitedDurationDocumentIndicator { get; set; }

    // A code that indicates whether a field has been truncated (‘T’), has not been truncated (‘N’), or unknown whether truncated (‘U’).
    [Element("DDE")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? FamilyNameTruncation { get; set; }

    // A code that indicates whether a field has been truncated (‘T’), has not been truncated (‘N’), or unknown whether truncated (‘U’).
    [Element("DDF")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? FirstNameTruncation { get; set; }

    // A code that indicates whether a field has been truncated (‘T’), has not been truncated (‘N’), or unknown whether truncated (‘U’).
    [Element("DDG")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? MiddleNameTruncation { get; set; }

    [Element("DDH")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Under18Until { get; set; }

    [Element("DDI")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Under19Until { get; set; }

    [Element("DDJ")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Under21Until { get; set; }

    // Indicator that the cardholder is an organ donor, can be ‘1’ or ‘0’
    [Element("DDK")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? OrganDonorIndicator { get; set; }

    [Element("PAA")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? PermitClassificationCode { get; set; }

    [Element("PAB")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? PermitExpirationDate { get; set; }

    [Element("PAC")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? PermitIdentifier { get; set; }

    [Element("PAD")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? PermitIssueDate { get; set; }

    [Element("PAE")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? PermitRestrictionCode { get; set; }

    [Element("PAF")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? PermitEndorsementCode { get; set; }

    [Element("ZVA")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? CourtRestrictionCode { get; set; }

    // Indicator that the cardholder is a veteran, can be ‘1’ or ‘0’
    [Element("DDL")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? VeteranIndicator { get; set; }

    // Florida
    [Element("ZFB")]
    [StringLength(24)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? FloridaSpecialRestrictions { get; set; }

    [Element("ZFC")]
    [StringLength(11)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? FloridaSafeDriverIndicator { get; set; }

    [Element("ZFD")]
    [StringLength(2)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? FloridaSexualPredator { get; set; }

    [Element("ZFE")]
    [StringLength(2)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? FloridaSexOffenderStatute { get; set; }

    [Element("ZFF")]
    [StringLength(11)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? FloridaInsulinDependent { get; set; }

    [Element("ZFG")]
    [StringLength(24)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? FloridaDevelopmentalDisability { get; set; }

    [Element("ZFH")]
    [StringLength(20)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? FloridaHearingImpaired { get; set; }

    // (SP=Sportsman, BO=Boater, FW=Freshwater Fishing, SW = Saltwater Fishing, HT=Hunting)
    [Element("ZFI")]
    [StringLength(14)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? FloridaFishWildlifeDesignations { get; set; }

    [Element("ZFJ")]
    [StringLength(10)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? FloridaCustomerNumber { get; set; }

    [Element("ZFA")]
    [StringLength(8)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? FloridaReplacedDate { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public IssuerIdentification? IssuerIdentification { get; set; }

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