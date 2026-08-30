// © Copyright (c) V5iD, Inc. All rights reserved.
// Licensed under the MIT.

using System.Globalization;

namespace V5iD.PublicSdk.Extension
{
    public static class StringExtension
    {
        public static bool EqualsDiacritics(this string str, string other, CompareOptions compareOptions = CompareOptions.IgnoreNonSpace)
        {
            // Compare with IgnoreNonSpace flag
            int result = CultureInfo.CurrentCulture.CompareInfo.Compare(
                str,
                other,
                CompareOptions.IgnoreNonSpace | compareOptions
            );

            return result == 0;
        }
    }
}
