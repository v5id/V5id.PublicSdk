// © Copyright (c) V5iD, Inc. All rights reserved.
// Licensed under the MIT.

namespace V5iD.PublicSdk.Models;

using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

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

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? DriverNameSuffix { get; set; }

    // can be ‘JR’, ‘SR’, ‘1ST’, ‘2ND’, ‘3RD’, ‘4TH’, ‘5TH’, ‘6TH’, ‘7TH’, ‘8TH’, ‘9TH’, ‘I’, ‘II’, ‘III’, ‘IV’, ‘V’, ‘VI’, ‘VII’, ‘VIII’ or ‘IX’
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? NameSuffix { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? DriverNamePrefix { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? MailingJurisdictionCode { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? MailingPostalCode { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? ResidenceStreetAddress1 { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? ResidenceStreetAddress2 { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? ResidenceCity { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? ResidenceJurisdictionCode { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? ResidencePostalCode { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? DocumentClassificationCode { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? DocumentRestrictionCode { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? DocumentEndorsementsCode { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? HeightInInches { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? HeightInCentimeters { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? WeightInLbs { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? WeightInKG { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? EyeColor { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? HairColor { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? IssueTimestamp { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? NumberOfDuplicates { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? MedicalIndicatorCodes { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? OrganDonor { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? NonResidentIndicator { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? UniqueCustomerIdentifier { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? SocialSecurityNumber { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? DriverSocialSecurityNumber { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? DriverDateOfBirth { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? DriverFullName { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? DriverFirstName { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? DriverMiddleName { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? DriverLastName { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? DriverSuffix { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? DriverPrefix { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? JurisdictionSpecificVehicleClass { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? JurisdictionSpecificRestrictions { get; set; }

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
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? WeightRange { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? DocumentDiscriminator { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? CountryTerritoryOfIssuance { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? FederalCommercialVehicleCodes { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? PlaceOfBirth { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? AuditInformation { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? InventoryControlNumber { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? RaceEthnicity { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? StandardVehicleClassification { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? StandardEndorsementCode { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? StandardRestrictionCode { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? JurisdictionVehicleClassification { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? JurisdictionEndorsementCode { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? JurisdictionRestrictionCode { get; set; }

    // Compliance Type, ‘F’ = fully compliant and ‘N’ = non-compliant.
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? ComplianceType { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? CardRevisionDate { get; set; }

    // Date on which the hazardous material endorsement granted by the document is no longer valid
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? HazMatEndorsementExpiryDate { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? LimitedDurationDocumentIndicator { get; set; }

    // A code that indicates whether a field has been truncated (‘T’), has not been truncated (‘N’), or unknown whether truncated (‘U’).
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? FamilyNameTruncation { get; set; }

    // A code that indicates whether a field has been truncated (‘T’), has not been truncated (‘N’), or unknown whether truncated (‘U’).
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? FirstNameTruncation { get; set; }

    // A code that indicates whether a field has been truncated (‘T’), has not been truncated (‘N’), or unknown whether truncated (‘U’).
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? MiddleNameTruncation { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Under18Until { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Under19Until { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Under21Until { get; set; }

    // Indicator that the cardholder is an organ donor, can be ‘1’ or ‘0’
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? OrganDonorIndicator { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? PermitClassificationCode { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? PermitExpirationDate { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? PermitIdentifier { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? PermitIssueDate { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? PermitRestrictionCode { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? PermitEndorsementCode { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? CourtRestrictionCode { get; set; }

    // Indicator that the cardholder is a veteran, can be ‘1’ or ‘0’
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? VeteranIndicator { get; set; }

    // Florida
    [StringLength(24)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? FloridaSpecialRestrictions { get; set; }

    [StringLength(11)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? FloridaSafeDriverIndicator { get; set; }

    [StringLength(2)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? FloridaSexualPredator { get; set; }

    [StringLength(2)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? FloridaSexOffenderStatute { get; set; }

    [StringLength(11)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? FloridaInsulinDependent { get; set; }

    [StringLength(24)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? FloridaDevelopmentalDisability { get; set; }

    [StringLength(20)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? FloridaHearingImpaired { get; set; }

    // (SP=Sportsman, BO=Boater, FW=Freshwater Fishing, SW = Saltwater Fishing, HT=Hunting)
    [StringLength(14)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? FloridaFishWildlifeDesignations { get; set; }

    [StringLength(10)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? FloridaCustomerNumber { get; set; }

    [StringLength(8)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? FloridaReplacedDate { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public IssuerIdentification? IssuerIdentification { get; set; }

    public Collection<string> Errors { get; } = [];
}
