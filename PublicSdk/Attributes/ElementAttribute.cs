namespace V5iD.PublicSdk.Attributes;

using System;

[AttributeUsage(AttributeTargets.Property)]
public sealed class ElementAttribute(string elementName) : Attribute
{
    public string ElementName { get; } = elementName;
}