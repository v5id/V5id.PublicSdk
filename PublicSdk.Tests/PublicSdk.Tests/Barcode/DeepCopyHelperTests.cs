// © Copyright (c) V5iD, Inc. All rights reserved.
// Licensed under the MIT.

using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using V5iD.PublicSdk.Helpers;
using V5iD.PublicSdk.Models;

namespace PublicSdk.Tests.Barcode
{
    public class DeepCopyHelperTests
    {
        public class BaseObject
        {
            public int Id { get; set; }

            public string? Name { get; set; }

            public DateTime? DateTime { get; set; }
        }

        public class TestObject : BaseObject
        {
            public string? AnotherDateTime { get; set; }
        }

        public class TestObject2 : TestObject
        {
            public List<string> Errors { get; set; } = [];
        }

        public class FormattedTestObject : BaseObject
        {
            public DateTime? AnotherDateTime { get; set; }
        }

        public class FormattedTestObject2 : FormattedTestObject
        {
            public List<string> Errors { get; set; } = [];
        }

        [Fact]
        public void BarcodeFormatting_ShouldInitializeObjectProperly()
        {
            // Arrange
            const string jsonBarcode =
                "{\"SourceString\":\"@\\n\\u001e\\rANSI 636020090102DL00410282ZC03230007DLDAQ170673217\\nDCSSAMPLE\\nDDEN\\nDACMINOR DRIVER LICENSE\\nDDFN\\nDADNONE\\nDDGN\\nDCAR\\nDCBC\\nDCDNONE\\nDBD12162021\\nDBB04202005\\nDBA05102026\\nDBC9\\nDAU062 in\\nDAYBLU\\nDAG1881 PIERCE ST\\nDAILAKEWOOD\\nDAJCO\\nDAK802140000  \\nDCF73055\\nDCGUSA\\nDDAF\\nDDB10302015\\nDAZSDY\\nDCJCDOR_DLU21_0_010422_01359\\nDCLU  \\nDAW120\\rZCZCAC\\r\",\"ComplianceIndicator\":\"@\",\"ElementSeparator\":\"\\n\",\"RecordSeparator\":\"\\u001e\",\"SegmentTerminator\":\"\\r\",\"IssuerIdentificationNumber\":\"636020\",\"AamvaVersionNumber\":\"09\",\"JurisdictionVersionNumber\":\"01\",\"NumberEntries\":\"02\",\"SubFileDesignator\":[],\"FileType\":\"ANSI \",\"MailingJurisdictionCode\":\"CO\",\"MailingPostalCode\":\"802140000  \",\"HeightInInches\":\"062 in\",\"WeightInLbs\":\"120\\r\",\"EyeColor\":\"BLU\",\"HairColor\":\"SDY\",\"JurisdictionSpecificVehicleClass\":\"R\",\"JurisdictionSpecificRestrictions\":\"C\",\"JurisdictionSpecificEndorsements\":\"NONE\",\"DocumentDiscriminator\":\"73055\",\"CountryTerritoryOfIssuance\":\"USA\",\"AuditInformation\":\"CDOR_DLU21_0_010422_01359\",\"RaceEthnicity\":\"U  \",\"ComplianceType\":\"F\",\"CardRevisionDate\":\"10302015\",\"FamilyNameTruncation\":\"N\",\"FirstNameTruncation\":\"N\",\"MiddleNameTruncation\":\"N\",\"IssuerIdentification\":{\"Issuer\":\"636020\",\"Jurisdiction\":\"Colorado\",\"Abbreviation\":\"CO\",\"Country\":1},\"Errors\":[],\"FirstName\":\"MINOR DRIVER LICENSE\",\"MiddleName\":\"NONE\",\"LastName\":\"SAMPLE\",\"DateOfBirth\":\"04202005\",\"Gender\":\"9\",\"DocumentNumber\":\"170673217\",\"DocumentIssueDate\":\"12162021\",\"DocumentExpirationDate\":\"05102026\",\"MailingStreetAddress1\":\"1881 PIERCE ST\",\"MailingCity\":\"LAKEWOOD\"}";

            // Act
            BarcodePdf417Formatted formatted = new(jsonBarcode);

            // Assert
            Assert.NotNull(formatted);
        }

        [Fact]
        public void Copy_ShouldCreateDeepCopy()
        {
            // Arrange
            TestObject original = new()
            {
                Id = 1,
                Name = "Test",
                DateTime = DateTime.UtcNow,
                AnotherDateTime = "04032021",
            };

            // Act
            FormattedTestObject copy = DeepCopyHelper.Copy<TestObject, FormattedTestObject>(original);

            // Assert
            Assert.Equal(original.Id, copy.Id);
            Assert.Equal(original.Name, copy.Name);
            Assert.Equal(original.DateTime, copy.DateTime);
            DateTime.TryParseExact(original.AnotherDateTime, "MMddyyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date);
            Assert.Equal(date, copy.AnotherDateTime);
            Assert.NotSame(original, copy);
        }

        [Fact]
        public void Copy_ShouldCopyErrorCollection()
        {
            // Arrange
            TestObject2 original = new()
            {
                Id = 1,
                Name = "Test",
                DateTime = DateTime.UtcNow,
                AnotherDateTime = "04032021",
                Errors = new List<string> { "Error1", "Error2" }
            };

            // Act
            FormattedTestObject2 copy = DeepCopyHelper.Copy<TestObject2, FormattedTestObject2>(original);
            // Assert
            Assert.Equal(original.Id, copy.Id);
            Assert.Equal(original.Name, copy.Name);
            Assert.Equal(original.DateTime, copy.DateTime);
            DateTime.TryParseExact(original.AnotherDateTime, "MMddyyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date);
            Assert.Equal(date, copy.AnotherDateTime);
            Assert.NotSame(original, copy);
            Assert.NotNull(copy.Errors);
            Assert.Equal(original.Errors.Count, copy.Errors.Count);
            Assert.Equal(original.Errors[0], copy.Errors[0]);
            Assert.Equal(original.Errors[1], copy.Errors[1]);
        }

        //BarcodePdf417Formatted barcodePdf417Formatted = DeepCopyHelper.Copy<BarcodePdf417, BarcodePdf417Formatted>(barcode);
        [Fact]
        public void Copy_ShouldCopyErrorCollectionBarcodePdf417()
        {
            // Arrange
            BarcodePdf417 original = new()
            {
                FirstName = "Alex",
                LastName = "Smith",
                DateOfBirth = "01011990",
            };

            original.Errors.Add("Error1");
            original.Errors.Add("Error2");

            // Act
            BarcodePdf417Formatted copy = DeepCopyHelper.Copy<BarcodePdf417, BarcodePdf417Formatted>(original);

            // Assert
            Assert.Equal(original.FirstName, copy.FirstName);
            Assert.Equal(original.LastName, copy.LastName);
            DateTime.TryParseExact(original.DateOfBirth, "MMddyyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date);
            Assert.Equal(date, copy.DateOfBirth);
            Assert.NotSame(original, copy);
            Assert.NotNull(copy.Errors);
            Assert.Equal(original.Errors.Count, copy.Errors.Count);
            Assert.Equal(original.Errors[0], copy.Errors[0]);
            Assert.Equal(original.Errors[1], copy.Errors[1]);
        }

        [Fact]
        public void Copy_ShouldThrowArgumentNullException()
        {
            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => DeepCopyHelper.Copy<TestObject, FormattedTestObject>(null!));
        }

        [Theory]
        [InlineData("19801008")]
        [InlineData("20261008")]
        [InlineData("19741008")]
        [InlineData("01051980")]
        [InlineData("10211980")]
        public void Copy_ShouldFormatAllDateFormats(string dateTimeString)
        {
            TestObject original = new()
            {
                AnotherDateTime = dateTimeString,
            };

            FormattedTestObject copy = DeepCopyHelper.Copy<TestObject, FormattedTestObject>(original);

            Assert.NotNull(copy.AnotherDateTime);
        }
    }
}