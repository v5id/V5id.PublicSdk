namespace V5id.Public.Sdk.Attributes;

using Enums;

[AttributeUsage(AttributeTargets.Property)]
internal class FormattingAttribute(FormattingType formattingType) : Attribute
{
    internal FormattingType FormattingType { get; } = formattingType;
}