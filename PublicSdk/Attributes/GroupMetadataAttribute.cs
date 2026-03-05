// © Copyright (c) V5iD, Inc. All rights reserved.
// Licensed under the MIT.

using System;

namespace V5iD.PublicSdk.Attributes
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    public class GroupMetadataAttribute : Attribute
    {
        public string Description { get; }
        public string Tooltip { get; }
        public int Order { get; }

        public GroupMetadataAttribute(string description, string tooltip, int order)
        {
            Description = description;
            Tooltip = tooltip;
            Order = order;
        }
    }
}