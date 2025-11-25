// © Copyright (c) V5iD, Inc. All rights reserved.
// Licensed under the MIT.

namespace V5iD.PublicSdk.Models;

using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;
using V5iD.PublicSdk.Attributes;
using V5iD.PublicSdk.Enums;
using V5iD.PublicSdk.Helpers;

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
        }
    }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? SourceString { get; set; }

    public char ComplianceIndicator { get; set; }

    public char ElementSeparator { get; set; }

    public char RecordSeparator { get; set; }

    public char SegmentTerminator { get; set; }

    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? IssuerIdentificationNumber { get; set; }

    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? AamvaVersionNumber { get; set; }

    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? JurisdictionVersionNumber { get; set; }

    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? NumberEntries { get; set; }

    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Collection<SubFileDesignator> SubFileDesignator { get; } = [];

    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? FileType { get; set; }

    [Element("DAE")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? DriverNameSuffix { get; set; }

    [Element("DCU")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? NameSuffix { get; set; }

    [Element("DAF")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? DriverNamePrefix { get; set; }

    [Element("DAJ")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? MailingJurisdictionCode { get; set; }

    [Element("DAK")]
    [Formatting(FormattingType.PostalCode)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? MailingPostalCode { get; set; }

    [Element("DAL")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? ResidenceStreetAddress1 { get; set; }

    [Element("DAM")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? ResidenceStreetAddress2 { get; set; }

    [Element("DAN")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? ResidenceCity { get; set; }

    [Element("DAO")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? ResidenceJurisdictionCode { get; set; }

    [Element("DAP")]
    [Formatting(FormattingType.PostalCode)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? ResidencePostalCode { get; set; }

    [Element("DAR")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? DocumentClassificationCode { get; set; }

    [Element("DAS")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? DocumentRestrictionCode { get; set; }

    [Element("DAT")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? DocumentEndorsementsCode { get; set; }

    [Element("DAU")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? HeightInInches { get; set; }

    [Element("DAV")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? HeightInCentimeters { get; set; }

    [Element("DAW")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? WeightInLbs { get; set; }

    [Element("DAX")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? WeightInKG { get; set; }

    [Element("DAY")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? EyeColor { get; set; }

    [Element("DAZ")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? HairColor { get; set; }

    [Element("DBE")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? IssueTimestamp { get; set; }

    [Element("DBF")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? NumberOfDuplicates { get; set; }

    [Element("DBG")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? MedicalIndicatorCodes { get; set; }

    [Element("DBH")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? OrganDonor { get; set; }

    [Element("DBI")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? NonResidentIndicator { get; set; }

    [Element("DBJ")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? UniqueCustomerIdentifier { get; set; }

    [Element("DBK")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? SocialSecurityNumber { get; set; }

    [Element("DBM")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? DriverSocialSecurityNumber { get; set; }

    [Element("DBL")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public DateTime? DriverDateOfBirth { get; set; }

    [Element("DBN")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? DriverFullName { get; set; }

    [Element("DBP")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? DriverFirstName { get; set; }

    [Element("DBQ")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? DriverMiddleName { get; set; }

    [Element("DBO")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? DriverLastName { get; set; }

    [Element("DBR")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? DriverSuffix { get; set; }

    [Element("DBS")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? DriverPrefix { get; set; }

    [Element("DCA")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? JurisdictionSpecificVehicleClass { get; set; }

    [Element("DCB")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? JurisdictionSpecificRestrictions { get; set; }

    [Element("DCD")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? JurisdictionSpecificEndorsements { get; set; }

    [Element("DCE")]
    [Formatting(FormattingType.Weight)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? WeightRange { get; set; }

    [Element("DCF")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? DocumentDiscriminator { get; set; }

    [Element("DCG")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? CountryTerritoryOfIssuance { get; set; }

    [Element("DCH")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? FederalCommercialVehicleCodes { get; set; }

    [Element("DCI")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public DateTime? PlaceOfBirth { get; set; }

    [Element("DCJ")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? AuditInformation { get; set; }

    [Element("DCK")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? InventoryControlNumber { get; set; }

    [Element("DCL")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? RaceEthnicity { get; set; }

    [Element("DCM")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? StandardVehicleClassification { get; set; }

    [Element("DCN")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? StandardEndorsementCode { get; set; }

    [Element("DCO")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? StandardRestrictionCode { get; set; }

    [Element("DCP")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? JurisdictionVehicleClassification { get; set; }

    [Element("DCQ")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? JurisdictionEndorsementCode { get; set; }

    [Element("DCR")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? JurisdictionRestrictionCode { get; set; }

    [Element("DDA")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? ComplianceType { get; set; }

    [Element("DDB")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public DateTime? CardRevisionDate { get; set; }

    [Element("DDC")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public DateTime? HazMatEndorsementExpiryDate { get; set; }

    [Element("DDD")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? LimitedDurationDocumentIndicator { get; set; }

    [Element("DDE")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? FamilyNameTruncation { get; set; }

    [Element("DDF")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? FirstNameTruncation { get; set; }

    [Element("DDG")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? MiddleNameTruncation { get; set; }

    [Element("DDH")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Under18Until { get; set; }

    [Element("DDI")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Under19Until { get; set; }

    [Element("DDJ")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Under21Until { get; set; }

    [Element("DDK")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? OrganDonorIndicator { get; set; }

    [Element("PAA")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? PermitClassificationCode { get; set; }

    [Element("PAB")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public DateTime? PermitExpirationDate { get; set; }

    [Element("PAC")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? PermitIdentifier { get; set; }

    [Element("PAD")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public DateTime? PermitIssueDate { get; set; }

    [Element("PAE")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? PermitRestrictionCode { get; set; }

    [Element("PAF")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? PermitEndorsementCode { get; set; }

    [Element("ZVA")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? CourtRestrictionCode { get; set; }

    [Element("DDL")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? VeteranIndicator { get; set; }

    [Element("ZFB")]
    [StringLength(24)]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? FloridaSpecialRestrictions { get; set; }

    [Element("ZFC")]
    [StringLength(11)]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? FloridaSafeDriverIndicator { get; set; }

    [Element("ZFD")]
    [StringLength(2)]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? FloridaSexualPredator { get; set; }

    [Element("ZFE")]
    [StringLength(2)]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? FloridaSexOffenderStatute { get; set; }

    [Element("ZFF")]
    [StringLength(11)]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? FloridaInsulinDependent { get; set; }

    [Element("ZFG")]
    [StringLength(24)]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? FloridaDevelopmentalDisability { get; set; }

    [Element("ZFH")]
    [StringLength(20)]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? FloridaHearingImpaired { get; set; }

    [Element("ZFI")]
    [StringLength(14)]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? FloridaFishWildlifeDesignations { get; set; }

    [Element("ZFJ")]
    [StringLength(10)]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? FloridaCustomerNumber { get; set; }

    [Element("ZFA")]
    [StringLength(8)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public DateTime? FloridaReplacedDate { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public IssuerIdentification? IssuerIdentification { get; set; }

    [Element("DAA")]
    [Formatting(FormattingType.Name)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? FullName { get; set; }

    [Element("DCT")]
    [Formatting(FormattingType.Name)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? GivenName { get; set; }

    [Element("DAC")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? FirstName { get; set; }

    [Element("DAD")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? MiddleName { get; set; }

    [Element("DCS")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? LastName { get; set; }

    [Element("DBB")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public DateTime? DateOfBirth { get; set; }

    [Element("DBC")]
    [Formatting(FormattingType.Gender)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Gender { get; set; }

    [Element("DAQ")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? DocumentNumber { get; set; }

    [Element("DBD")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public DateTime? DocumentIssueDate { get; set; }

    [Element("DBA")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public DateTime? DocumentExpirationDate { get; set; }

    [Element("DAG")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? MailingStreetAddress1 { get; set; }

    [Element("DAH")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? MailingStreetAddress2 { get; set; }

    [Element("DAI")]
    [Formatting(FormattingType.None)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? MailingCity { get; set; }

    public Collection<string> Errors { get; } = [];
}