// © Copyright (c) V5iD, Inc. All rights reserved.
// Licensed under the MIT.

using System;

namespace V5iD.PublicSdk.Attributes
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    public sealed class TooltipAttribute : Attribute
    {
        public string Tooltip { get; }

        public TooltipAttribute(string tooltip)
        {
            Tooltip = tooltip;
        }
    }
}