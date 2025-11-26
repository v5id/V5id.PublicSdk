// © Copyright (c) V5iD, Inc. All rights reserved.
// Licensed under the MIT.

using System.Text.Json;
using V5iD.PublicSdk.Models;

namespace PublicSdk.Tests.Barcode
{
    public class BarcodePdf417Tests
    {
        [Fact]
        public void BarcodePdf417ImplicitOperator_CanadianSourceString_ShouldProcessWithoutErrors()
        {
            string rawBarcodeJson =
                "{\r\n  \"SourceString\": \"@\\n\\u001E\\rANSI 636012090002DL00410217ZO02580062DLDCAG\\nDCB\\nDCD\\nDBA20261008\\nDCSDOE\\nDACEVELYN\\nDADMARIE\\nDBD20211101\\nDBB19831215\\nDBC2\\nDAYUNK\\nDAU173 cm\\nDAG123 FAKE ST\\nDAINEPEAN\\nDAJON\\nDAKK3G4B6 \\nDAQK04093196746008\\nDCFHD4743433\\nDCGCAN\\nDDEN\\nDDFN\\nDDGN\\nDCK*2108024*\\rZOZODOE,EVELYN,MARIE\\nZOBY\\nZOC\\nZOD\\nZOE\\nZOZK0409-31967-46008\\r\",\r\n  \"ComplianceIndicator\": \"@\",\r\n  \"ElementSeparator\": \"\\n\",\r\n  \"RecordSeparator\": \"\\u001E\",\r\n  \"SegmentTerminator\": \"\\r\",\r\n  \"IssuerIdentificationNumber\": \"636012\",\r\n  \"AamvaVersionNumber\": \"09\",\r\n  \"JurisdictionVersionNumber\": \"00\",\r\n  \"NumberEntries\": \"02\",\r\n  \"SubFileDesignator\": [\r\n    {\r\n      \"SubFileType\": \"DL\",\r\n      \"Offset\": \"0041\",\r\n      \"Length\": \"0217\"\r\n    },\r\n    {\r\n      \"SubFileType\": \"ZO\",\r\n      \"Offset\": \"0258\",\r\n      \"Length\": \"0062\"\r\n    }\r\n  ],\r\n  \"FileType\": \"ANSI \",\r\n  \"MailingJurisdictionCode\": \"ON\",\r\n  \"MailingPostalCode\": \"K3G4B6 \",\r\n  \"HeightInInches\": \"173 cm\",\r\n  \"EyeColor\": \"UNK\",\r\n  \"JurisdictionSpecificVehicleClass\": \"G\",\r\n  \"JurisdictionSpecificRestrictions\": \"\",\r\n  \"JurisdictionSpecificEndorsements\": \"\",\r\n  \"DocumentDiscriminator\": \"HD4743433\",\r\n  \"CountryTerritoryOfIssuance\": \"CAN\",\r\n  \"InventoryControlNumber\": \"*2108024*\\rZOZO\",\r\n  \"FamilyNameTruncation\": \"N\",\r\n  \"FirstNameTruncation\": \"N\",\r\n  \"MiddleNameTruncation\": \"N\",\r\n  \"IssuerIdentification\": {\r\n    \"Issuer\": \"636012\",\r\n    \"Jurisdiction\": \"Ontario\",\r\n    \"Abbreviation\": \"ON\",\r\n    \"Country\": \"Canada\"\r\n  },\r\n  \"Errors\": [\r\n    \"Invalid session length or offset.\"\r\n  ],\r\n  \"FirstName\": \"EVELYN\",\r\n  \"MiddleName\": \"MARIE\",\r\n  \"LastName\": \"DOE\",\r\n  \"DateOfBirth\": \"19831215\",\r\n  \"Gender\": \"2\",\r\n  \"DocumentNumber\": \"K04093196746008\",\r\n  \"DocumentIssueDate\": \"20211101\",\r\n  \"DocumentExpirationDate\": \"20261008\",\r\n  \"MailingStreetAddress1\": \"123 FAKE ST\",\r\n  \"MailingCity\": \"NEPEAN\"\r\n}\r\n";

            BarcodePdf417 barcode = JsonSerializer.Deserialize<BarcodePdf417>(rawBarcodeJson)!;
            BarcodePdf417Formatted formattedBarcode = barcode;

            Assert.Empty(formattedBarcode.Errors);
        }
    }
}