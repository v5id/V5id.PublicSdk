// © Copyright (c) V5iD, Inc. All rights reserved.
// Licensed under the MIT.

using System;
using System.ComponentModel;
using System.Reflection;
using V5iD.PublicSdk.Attributes;

namespace V5iD.PublicSdk.Enums.Extensions
{
    public static class EnumExtension
    {
        public static string GetDescription(this Enum value)
        {
            var fi = value.GetType().GetField(value.ToString()) ?? throw new ArgumentNullException(nameof(value));
            var attr = fi.GetCustomAttribute<DescriptionAttribute>(false);
            return attr?.Description ?? value.ToString();
        }
    
        public static string? GetTooltip(this Enum value)
        {
            var fi = value.GetType().GetField(value.ToString()) ?? throw new ArgumentNullException(nameof(value));
            var attr = fi.GetCustomAttribute<TooltipAttribute>(false);
            return attr?.Tooltip;
        }

        public static GroupMetadataAttribute? GetGroupMetadata(this Enum value)
        {
            var fi = value.GetType().GetField(value.ToString()) ?? throw new ArgumentNullException(nameof(value));
            return fi.GetCustomAttribute<GroupMetadataAttribute>(false);
        }

        public static int? GetGroupOrder(this Enum value)
        {
            return value.GetGroupMetadata()?.Order;
        }

        public static string? GetGroupTooltip(this Enum value)
        {
            return value.GetGroupMetadata()?.Tooltip;
        }

        public static string? GetGroupDescription(this Enum value)
        {
            return value.GetGroupMetadata()?.Description;
        }
    }
}