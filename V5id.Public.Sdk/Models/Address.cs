namespace V5id.Public.Sdk.Models;

public class Address
{
    public Guid AddressUuid { get; init; }

    public required string Street { get; init; }

    public required string City { get; init; }

    public required string State { get; init; }

    public required string PostalCode { get; init; }

    public required string Country { get; init; }

    public bool IsAddressConfirmed { get; init; }
}