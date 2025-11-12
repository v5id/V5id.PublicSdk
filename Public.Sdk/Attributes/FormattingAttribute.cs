namespace V5id.Public.Sdk.Attributes;

using System;
using Enums;

[AttributeUsage(AttributeTargets.Property)]
internal sealed class FormattingAttribute(FormattingType formattingType) : Attribute
{
    internal FormattingType FormattingType { get; } = formattingType;
}