// © Copyright (c) V5iD, Inc. All right reserved.
// Licensed under the MIT.

namespace V5iD.PublicSdk.Helpers;

using System;
using System.Collections.ObjectModel;
using System.Linq;
using Models;

internal static class FormattingHelper
{
    /// <summary>
    /// Formats a postal code by trimming whitespace and optionally inserting a hyphen.
    /// </summary>
    /// <param name="value">The postal code string to format.</param>
    /// <param name="errors">A collection to hold any errors that occur during formatting.</param>
    /// <returns>The formatted postal code string or the trimmed value if formatting fails.</returns>
    public static string FormatCode(string value, Collection<string> errors)
    {
        string trimmedValue = value.Trim();

        if (trimmedValue.All(char.IsDigit))
        {
            return trimmedValue.Length > 5 ? trimmedValue.Insert(5, "-") : trimmedValue;
        }
        else if (trimmedValue.Length == 6)
        {
            return trimmedValue.Insert(3, " ");
        }
        else
        {
            errors.Add("Postal code could not be formatted.");
            return trimmedValue;
        }
    }

    /// <summary>
    /// Formats a gender code to its corresponding letter representation.
    /// </summary>
    /// <param name="value">The gender code to format.</param>
    /// <param name="errors">A collection to hold any errors that occur during formatting.</param>
    /// <returns>The formatted gender letter or "N" if the code is unknown.</returns>
    public static string FormatGender(string value, Collection<string> errors)
    {
        switch (value)
        {
            case "1":
                return "M";
            case "2":
                return "F";
            case "9":
                return "N";
            default:
                errors.Add("Unknown gender.");
                return "N";
        }
    }

    /// <summary>
    /// Formats a weight code to its corresponding weight range string.
    /// </summary>
    /// <param name="value">The weight code to format.</param>
    /// <param name="errors">A collection to hold any errors that occur during formatting.</param>
    /// <returns>The formatted weight range string or "131 - 160 lbs" if the code is unknown.</returns>
    public static string FormatWeight(string value, Collection<string> errors)
    {
        switch (value)
        {
            case "0":
                return "up to 70 lbs";
            case "1":
                return "71 - 100 lbs";
            case "2":
                return "101 - 130 lbs";
            case "3":
                return "131 - 160 lbs";
            case "4":
                return "161 - 190 lbs";
            case "5":
                return "191 - 220 lbs";
            case "6":
                return "221 - 250 lbs";
            case "7":
                return "251 - 280 lbs";
            case "8":
                return "281 - 320 lbs";
            case "9":
                return "321+ lbs";
            default:
                errors.Add("Unknown weight range.");
                return "Invalid weight";
        }
    }

    /// <summary>
    /// Formats the name components (first, middle, last) of the given <see cref="BarcodePdf417Formatted"/> object.
    /// </summary>
    /// <param name="barcode">The <see cref="BarcodePdf417Formatted"/> object containing name components to be formatted.</param>
    /// <remarks>
    /// This method checks if the middle name is already set. If it is not, it attempts to split the first name or given name into individual components.
    /// If either the first name or given name contains two parts, the second part is assigned as the middle name. If it contains three parts,
    /// the first part is assigned as the first name, the second as the given name, and the third as the middle name. 
    /// If both first and given names are empty, an error message is added to the errors list.
    /// </remarks>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="barcode"/> is null.</exception>
    public static void FormatName(BarcodePdf417Formatted barcode)
    {
        (barcode.FirstName, barcode.MiddleName) = SplitName(barcode.FirstName, barcode.MiddleName);
        (barcode.GivenName, barcode.MiddleName) = SplitName(barcode.GivenName, barcode.MiddleName);
        (barcode.DriverFirstName, barcode.DriverMiddleName) = SplitName(barcode.DriverFirstName, barcode.DriverMiddleName);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="nameString">The name string to be split into components.</param>
    /// <param name="middleName">The middle name</param>
    /// <returns>First/Given name and the middle name</returns>
    private static (string? first, string? middle) SplitName(string? nameString, string? middleName)
    {
        if (string.IsNullOrEmpty(middleName) && !string.IsNullOrWhiteSpace(nameString))
        {
            string[] names = nameString.Split(' ');
            if (names.Length > 1)
            {
                int firstSpaceIndex = nameString.IndexOf(' ', StringComparison.InvariantCultureIgnoreCase);

                return (first: names[0], middle: (firstSpaceIndex == -1) ? string.Empty : nameString[(firstSpaceIndex + 1)..]);
            }
        }

        return (first: nameString, middle: middleName); 
    } 
}