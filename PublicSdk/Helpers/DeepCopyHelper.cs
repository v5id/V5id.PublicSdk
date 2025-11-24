// © Copyright (c) V5iD, Inc. All right reserved.
// Licensed under the MIT.

namespace V5iD.PublicSdk.Helpers;

using System;
using System.Globalization;
using System.Linq;
using System.Reflection;

internal static class DeepCopyHelper
{
    /// <summary>
    /// Copies properties from a source object of type <typeparamref name="TSource"/> to a new instance of type <typeparamref name="TTarget"/>.
    /// </summary>
    /// <typeparam name="TSource">The type of the source object.</typeparam>
    /// <typeparam name="TTarget">The type of the target object, must have a parameterless constructor.</typeparam>
    /// <param name="source">The source object to copy properties from.</param>
    /// <returns>A new instance of type <typeparamref name="TTarget"/> with copied properties from <paramref name="source"/>.</returns>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="source"/> is null.</exception>
    internal static TTarget Copy<TSource, TTarget>(TSource source) where TSource : class where TTarget : class, new()
    {
        ArgumentNullException.ThrowIfNull(source);

        TTarget target = new();
        PropertyInfo[] sourceProperties = typeof(TSource).GetProperties();
        PropertyInfo[] targetProperties = typeof(TTarget).GetProperties();

        foreach (PropertyInfo sourceProperty in sourceProperties)
        {
            PropertyInfo? targetProperty = targetProperties.FirstOrDefault(p => p.Name == sourceProperty.Name);

            if (targetProperty != null && targetProperty.CanWrite)
            {
                object? value = sourceProperty.GetValue(source);

                if (value == null)
                {
                    targetProperty.SetValue(target, null);
                }
                else if (targetProperty.PropertyType == typeof(DateTime?) && value is string stringValue)
                {
                    targetProperty.SetValue(target, ConvertToDateTime(stringValue));
                }
                else if (targetProperty.PropertyType == sourceProperty.PropertyType)
                {
                    targetProperty.SetValue(target, value);
                }
                else
                {
                    targetProperty.SetValue(target, Convert.ChangeType(value, targetProperty.PropertyType, CultureInfo.InvariantCulture));
                }
            }
        }

        return target;
    }

    /// <summary>
    /// Copies properties and fields from a source object to a destination object.
    /// </summary>
    /// <param name="source">The source object to copy properties and fields from.</param>
    /// <param name="destination">The destination object to copy properties and fields to.</param>
    /// <exception cref="ArgumentNullException">
    /// Thrown when either <paramref name="source"/> or <paramref name="destination"/> is null.
    /// </exception>
    /// <remarks>
    /// This method uses reflection to copy all public and non-public properties and fields
    /// from the source object to the destination object, provided that the properties and fields 
    /// have the same names and compatible types.
    /// </remarks>
    internal static void CopyProperties(object source, object destination)
    {
        if (source == null || destination == null)
            throw new ArgumentNullException(source == null ? nameof(source) : nameof(destination));

        Type sourceType = source.GetType();
        Type destinationType = destination.GetType();

        foreach (var sourceProperty in sourceType.GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance))
        {
            var destinationProperty = destinationType.GetProperty(sourceProperty.Name, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);

            if (destinationProperty != null && destinationProperty.CanWrite)
            {
                var value = sourceProperty.GetValue(source, null);
                destinationProperty.SetValue(destination, value, null);
            }
        }

        foreach (var sourceField in sourceType.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance))
        {
            var destinationField = destinationType.GetField(sourceField.Name, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);

            if (destinationField != null)
            {
                var value = sourceField.GetValue(source);
                destinationField.SetValue(destination, value);
            }
        }
    }

    private static DateTime? ConvertToDateTime(string? dateString)
    {
        if (dateString == null) return null;

        string[] dateFormats =
        [
            // US formats
            "MM/dd/yyyy",
            "M/d/yyyy",
            "MM.dd.yyyy",
            "M.d.yyyy",
            "MM,dd,yyyy",
            "M,d,yyyy",
            "MMddyyyy",
            "MM/dd/yyyy HH:mm:ss K",
            "MM/dd/yyyy HH:mm:ss zzz",
            "MM/dd/yyyy HH:mm:ss",
            "MM/dd/yyyy H:mm:ss",
            "MM/dd/yyyy HH:mm:ss 'GMT'zzz",
            "yyyy-MM-dd",

            // Other formats
            "dd/MM/yyyy",
            "d/M/yyyy",
            "dd.MM.yyyy",
            "dd,MM,yyyy",
            "d.M.yyyy",
            "dd-MM-yyyy",
            "d-M-yyyy",
            "ddMMyyyy",
            "yyyyMMdd",
            "yyyy-MM-ddTHH:mm:ssK",
            "dd/MM/yyyy HH:mm:ss",
            "d/M/yyyy H:mm:ss",
            "dd.MM.yyyy HH:mm:ss",
            "d.M.yyyy H:mm:ss",
            "dd-MM-yyyy HH:mm:ss",
            "d-M-yyyy H:mm:ss",
            "ddMMyyyy HH:mm:ss"
        ];

        if (DateTime.TryParseExact(dateString, dateFormats, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime result))
        {
            return result;
        }

        return null;
    }
}