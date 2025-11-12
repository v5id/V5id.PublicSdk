namespace V5id.Public.Sdk.Attributes;

using System;

[AttributeUsage(AttributeTargets.Property)]
internal sealed class ElementAttribute(string elementName) : Attribute
{
    internal string ElementName { get; } = elementName;
}