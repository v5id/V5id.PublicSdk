namespace V5id.Public.Sdk.Attributes;

[AttributeUsage(AttributeTargets.Property)]
internal class ElementAttribute(string elementName) : Attribute
{
    internal string ElementName { get; } = elementName;
}