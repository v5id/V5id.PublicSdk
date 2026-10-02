// © Copyright (c) V5iD, Inc. All rights reserved.
// Licensed under the MIT.

using System.Globalization;
using V5iD.PublicSdk.Extension;
namespace PublicSdk.Tests
{
    public class StringExtensionFixture
    {
        [Fact]
        public void EqualsDiacritics_ShouldReturnTrue_ForEquivalentStringsWithDiacritics()
        {
            // Arrange
            string str1 = "AAABBCC";
            string str2 = "ÄÁÅḂB́ĈĊ";
            // Act
            bool result = str1.EqualsDiacritics(str2);
            // Assert
            Assert.True(result);
        }

        [Fact]
        public void EqualsDiacritics_ShouldReturnFalse_ForEquivalentStringsWithDiacriticsDifferentCase()
        {
            // Arrange
            string str1 = "AAABBCCC";
            string str2 = "ÄÁÅḂB́ĈĊĉ";
            // Act
            bool result = str1.EqualsDiacritics(str2);
            // Assert
            Assert.False(result);
        }

        [Fact]
        public void EqualsDiacritics_ShouldReturnTrue_ForEquivalentStringsWithDiacriticsDifferentCase()
        {
            // Arrange
            string str1 = "AAABBCCC";
            string str2 = "ÄÁÅḂB́ĈĊĉ";
            // Act
            bool result = str1.EqualsDiacritics(str2, CompareOptions.IgnoreCase);
            // Assert
            Assert.True(result);
        }
    }
}
