// © Copyright (c) V5iD, Inc. All right reserved.
// Licensed under the MIT.

using System.Collections.ObjectModel;
using V5iD.PublicSdk.Helpers;
using V5iD.PublicSdk.Models;

namespace PublicSdk.Tests
{
    public class FormattingHelperTests
{
    public class TestObject
    {
        public string Date { get; set; } = string.Empty;

        public string Code { get; set; } = string.Empty;

        public string Gender { get; set; } = string.Empty;

        public string Weight { get; set; } = string.Empty;

        public Collection<string> Errors { get; set; } = [];
    }

    [Fact]
    public void FormatData_FormatCode_ShouldFormatCorrectly()
    {
        // Arrange
        TestObject testObject = new() { Code = "4839482398" };

        // Act
        string result = FormattingHelper.FormatCode(testObject.Code, testObject.Errors);

        // Assert
        Assert.Equal("48394-82398", result);
        Assert.True(testObject.Errors.Count == 0);
    }

    [Fact]
    public void FormatData_InvalidCode_ShouldReturnSameValue()
    {
        // Arrange
        TestObject testObject = new() { Code = "4839A82398" };

        // Act
        string result = FormattingHelper.FormatCode(testObject.Code, testObject.Errors);

        // Assert
        Assert.Equal("4839A82398", result);
        Assert.True(testObject.Errors.Count > 0);
    }

    [Fact]
    public void FormatData_FormatGender_ShouldFormatCorrectly()
    {
        // Arrange
        TestObject testObject = new() { Gender = "1" };

        // Act
        string result = FormattingHelper.FormatGender(testObject.Gender, testObject.Errors);

        // Assert
        Assert.Equal("M", result);
        Assert.True(testObject.Errors.Count == 0);
    }

    [Fact]
    public void FormatData_InvalidGender_ShouldReturnN()
    {
        // Arrange
        TestObject testObject = new() { Gender = "3" };

        // Act
        string result = FormattingHelper.FormatGender(testObject.Gender, testObject.Errors);

        // Assert
        Assert.Equal("N", result);
        Assert.True(testObject.Errors.Count > 0);
    }

    [Fact]
    public void FormatData_FormatWeight_ShouldFormatCorrectly()
    {
        // Arrange
        TestObject testObject = new() { Weight = "3" };

        // Act
        string result = FormattingHelper.FormatWeight(testObject.Weight, testObject.Errors);

        // Assert
        Assert.Equal("131 - 160 lbs", result);
        Assert.True(testObject.Errors.Count == 0);
    }

    [Fact]
    public void FormatData_InvalidWeight_ShouldReturnUnknownWeightRange()
    {
        // Arrange
        TestObject testObject = new() { Weight = "10" };

        // Act
        string result = FormattingHelper.FormatWeight(testObject.Weight, testObject.Errors);

        // Assert
        Assert.Equal("Invalid weight", result);
        Assert.True(testObject.Errors.Count > 0);
    }

    [Fact]
    public void FormatName_ValidFullName_ShouldFormatCorrectly()
    {
        // Arrange
        BarcodePdf417Formatted barcode = new()
        {
            FirstName = "Geoffrey Clay",
            LastName = "Dickey",
            FullName = "Geoffrey Clay Dickey",
        };

        // Act
        FormattingHelper.FormatName(barcode);

        // Assert
        Assert.Equal("Geoffrey", barcode.FirstName);
        Assert.Equal("Clay", barcode.MiddleName);
        Assert.NotNull(barcode.LastName);
        Assert.NotNull(barcode.FullName);
        Assert.Empty(barcode.Errors);
    }

    [Fact]
    public void FormatName_NoMiddleName_ShouldFormatCorrectly()
    {
        // Arrange
        BarcodePdf417Formatted barcode = new()
        {
            FirstName = "Geoffrey",
            LastName = "Dickey",
            FullName = "Geoffrey Dickey",
        };

        // Act
        FormattingHelper.FormatName(barcode);

        // Assert
        Assert.Equal("Geoffrey", barcode.FirstName);
        Assert.Null(barcode.MiddleName);
        Assert.NotNull(barcode.LastName);
        Assert.NotNull(barcode.FullName);
        Assert.Empty(barcode.Errors);
    }

    [Fact]
    public void FormatName_NoFirstName_ShouldAddError()
    {
        // Arrange
        BarcodePdf417Formatted barcode = new()
        {
            LastName = "Dickey",
        };

        // Act
        FormattingHelper.FormatName(barcode);

        // Assert
        Assert.Null(barcode.FirstName);
        Assert.Null(barcode.MiddleName);
        Assert.Equal("Dickey", barcode.LastName);
    }
}
}