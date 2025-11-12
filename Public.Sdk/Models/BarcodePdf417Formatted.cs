namespace V5id.Public.Sdk.Models;

using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;
using Attributes;
using Enums;
using Helpers;

public class BarcodePdf417Formatted
{
     public BarcodePdf417Formatted() { }

    public BarcodePdf417Formatted(string json)
    {
        try
        {
            BarcodePdf417? barcode = JsonSerializer.Deserialize<BarcodePdf417>(json) ??
                throw new InvalidOperationException("Failed to deserialize BarcodePdf417 from JSON.");

            BarcodePdf417Formatted formatted = barcode;
            DeepCopyHelper.CopyProperties(formatted, this);
        }
        catch (Exception exception)
        {
            Errors.Add(exception.Message);
            throw new FormatException("Formatting error", exception);
        }
    }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? SourceString { get; internal set; }

    public char ComplianceIndicator { get; internal set; }

    public char ElementSeparator { get; internal set; }

    public char RecordSeparator { get; internal set; }

    public char SegmentTerminator { get; internal set; }

    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? IssuerIdentificationNumber { get; internal set; }

    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? AamvaVersionNumber { get; internal set; }

    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? JurisdictionVersionNumber { get; internal set; }

    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? NumberEntries { get; internal set; }

    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Collection<SubFileDesignator> SubFileDesignator { get; } = [];

    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? FileType { get; internal set; }

    [Element("DAE")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? DriverNameSuffix { get; internal set; }

    [Element("DCU")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? NameSuffix { get; internal set; }

    [Element("DAF")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? DriverNamePrefix { get; internal set; }

    [Element("DAJ")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? MailingJurisdictionCode { get; internal set; }

    [Element("DAK")]
    [Formatting(FormattingType.PostalCode)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? MailingPostalCode { get; internal set; }

    [Element("DAL")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? ResidenceStreetAddress1 { get; internal set; }

    [Element("DAM")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? ResidenceStreetAddress2 { get; internal set; }

    [Element("DAN")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? ResidenceCity { get; internal set; }

    [Element("DAO")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? ResidenceJurisdictionCode { get; internal set; }

    [Element("DAP")]
    [Formatting(FormattingType.PostalCode)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? ResidencePostalCode { get; internal set; }

    [Element("DAR")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? DocumentClassificationCode { get; internal set; }

    [Element("DAS")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? DocumentRestrictionCode { get; internal set; }

    [Element("DAT")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? DocumentEndorsementsCode { get; internal set; }

    [Element("DAU")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? HeightInInches { get; internal set; }

    [Element("DAV")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? HeightInCentimeters { get; internal set; }

    [Element("DAW")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? WeightInLbs { get; internal set; }

    [Element("DAX")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? WeightInKG { get; internal set; }

    [Element("DAY")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? EyeColor { get; internal set; }

    [Element("DAZ")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? HairColor { get; internal set; }

    [Element("DBE")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? IssueTimestamp { get; internal set; }

    [Element("DBF")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? NumberOfDuplicates { get; internal set; }

    [Element("DBG")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? MedicalIndicatorCodes { get; internal set; }

    [Element("DBH")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? OrganDonor { get; internal set; }

    [Element("DBI")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? NonResidentIndicator { get; internal set; }

    [Element("DBJ")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? UniqueCustomerIdentifier { get; internal set; }

    [Element("DBK")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? SocialSecurityNumber { get; internal set; }

    [Element("DBM")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? DriverSocialSecurityNumber { get; internal set; }

    [Element("DBL")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public DateTime? DriverDateOfBirth { get; internal set; }

    [Element("DBN")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? DriverFullName { get; internal set; }

    [Element("DBP")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? DriverFirstName { get; internal set; }

    [Element("DBQ")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? DriverMiddleName { get; internal set; }

    [Element("DBO")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? DriverLastName { get; internal set; }

    [Element("DBR")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? DriverSuffix { get; internal set; }

    [Element("DBS")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? DriverPrefix { get; internal set; }

    [Element("DCA")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? JurisdictionSpecificVehicleClass { get; internal set; }

    [Element("DCB")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? JurisdictionSpecificRestrictions { get; internal set; }

    [Element("DCD")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? JurisdictionSpecificEndorsements { get; internal set; }

    [Element("DCE")]
    [Formatting(FormattingType.Weight)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? WeightRange { get; internal set; }

    [Element("DCF")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? DocumentDiscriminator { get; internal set; }

    [Element("DCG")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? CountryTerritoryOfIssuance { get; internal set; }

    [Element("DCH")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? FederalCommercialVehicleCodes { get; internal set; }

    [Element("DCI")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public DateTime? PlaceOfBirth { get; internal set; }

    [Element("DCJ")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? AuditInformation { get; internal set; }

    [Element("DCK")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? InventoryControlNumber { get; internal set; }

    [Element("DCL")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? RaceEthnicity { get; internal set; }

    [Element("DCM")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? StandardVehicleClassification { get; internal set; }

    [Element("DCN")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? StandardEndorsementCode { get; internal set; }

    [Element("DCO")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? StandardRestrictionCode { get; internal set; }

    [Element("DCP")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? JurisdictionVehicleClassification { get; internal set; }

    [Element("DCQ")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? JurisdictionEndorsementCode { get; internal set; }

    [Element("DCR")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? JurisdictionRestrictionCode { get; internal set; }

    [Element("DDA")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? ComplianceType { get; internal set; }

    [Element("DDB")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public DateTime? CardRevisionDate { get; internal set; }

    [Element("DDC")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public DateTime? HazMatEndorsementExpiryDate { get; internal set; }

    [Element("DDD")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? LimitedDurationDocumentIndicator { get; internal set; }

    [Element("DDE")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? FamilyNameTruncation { get; internal set; }

    [Element("DDF")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? FirstNameTruncation { get; internal set; }

    [Element("DDG")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? MiddleNameTruncation { get; internal set; }

    [Element("DDH")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Under18Until { get; internal set; }

    [Element("DDI")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Under19Until { get; internal set; }

    [Element("DDJ")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Under21Until { get; internal set; }

    [Element("DDK")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? OrganDonorIndicator { get; internal set; }

    [Element("PAA")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? PermitClassificationCode { get; internal set; }

    [Element("PAB")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public DateTime? PermitExpirationDate { get; internal set; }

    [Element("PAC")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? PermitIdentifier { get; internal set; }

    [Element("PAD")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public DateTime? PermitIssueDate { get; internal set; }

    [Element("PAE")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? PermitRestrictionCode { get; internal set; }

    [Element("PAF")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? PermitEndorsementCode { get; internal set; }

    [Element("ZVA")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? CourtRestrictionCode { get; internal set; }

    [Element("DDL")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? VeteranIndicator { get; internal set; }

    [Element("ZFB")]
    [StringLength(24)]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? FloridaSpecialRestrictions { get; internal set; }

    [Element("ZFC")]
    [StringLength(11)]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? FloridaSafeDriverIndicator { get; internal set; }

    [Element("ZFD")]
    [StringLength(2)]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? FloridaSexualPredator { get; internal set; }

    [Element("ZFE")]
    [StringLength(2)]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? FloridaSexOffenderStatute { get; internal set; }

    [Element("ZFF")]
    [StringLength(11)]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? FloridaInsulinDependent { get; internal set; }

    [Element("ZFG")]
    [StringLength(24)]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? FloridaDevelopmentalDisability { get; internal set; }

    [Element("ZFH")]
    [StringLength(20)]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? FloridaHearingImpaired { get; internal set; }

    [Element("ZFI")]
    [StringLength(14)]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? FloridaFishWildlifeDesignations { get; internal set; }

    [Element("ZFJ")]
    [StringLength(10)]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? FloridaCustomerNumber { get; internal set; }

    [Element("ZFA")]
    [StringLength(8)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public DateTime? FloridaReplacedDate { get; internal set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public IssuerIdentification? IssuerIdentification { get; internal set; }

    [Element("DAA")]
    [Formatting(FormattingType.Name)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? FullName { get; internal set; }

    [Element("DCT")]
    [Formatting(FormattingType.Name)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? GivenName { get; internal set; }

    [Element("DAC")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? FirstName { get; internal set; }

    [Element("DAD")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? MiddleName { get; internal set; }

    [Element("DCS")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? LastName { get; internal set; }

    [Element("DBB")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public DateTime? DateOfBirth { get; internal set; }

    [Element("DBC")]
    [Formatting(FormattingType.Gender)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Gender { get; internal set; }

    [Element("DAQ")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? DocumentNumber { get; internal set; }

    [Element("DBD")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public DateTime? DocumentIssueDate { get; internal set; }

    [Element("DBA")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public DateTime? DocumentExpirationDate { get; internal set; }

    [Element("DAG")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? MailingStreetAddress1 { get; internal set; }

    [Element("DAH")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? MailingStreetAddress2 { get; internal set; }

    [Element("DAI")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? MailingCity { get; internal set; }

    public Collection<string> Errors { get; } = [];
}