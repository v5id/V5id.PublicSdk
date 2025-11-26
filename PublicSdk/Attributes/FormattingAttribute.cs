// © Copyright (c) V5iD, Inc. All rights reserved.
// Licensed under the MIT.

namespace V5iD.PublicSdk.Attributes;

using System;
using Enums;

[AttributeUsage(AttributeTargets.Property)]
internal sealed class FormattingAttribute(FormattingType formattingType) : Attribute
{
    internal FormattingType FormattingType { get; } = formattingType;
}