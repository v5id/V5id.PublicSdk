namespace V5id.Public.Sdk.Models;

using Enums;

public class MrzDetail
{
    public string FirstName { get; init; } = string.Empty;
    
    public string LastName { get; init; } = string.Empty;

    public string MiddleName { get; init; } = string.Empty;
        
    public string DocumentNumber { get; init; } = string.Empty;
        
    public string CountryRegion { get; init; } = string.Empty;

    public string Nationality { get; init; } = string.Empty;

    public DateTimeOffset? DateOfBirth { get; init; }

    public DateTimeOffset? DateOfExpiration { get; init; }

    public string Sex { get; init; } = string.Empty;
        
    public MrzType MrzType { get; init; }

    public IList<MrzAnalyzer>? MrzAnalyzerResponses { get; init; }
}