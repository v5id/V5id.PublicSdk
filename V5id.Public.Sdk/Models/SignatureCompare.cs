namespace V5id.Public.Sdk.Models;

public class SignatureCompare
{
    public Guid SignatureCompareResultUuid { get; init; }

    public required Guid SourceSignature { get; init; }

    public required Guid TargetSignature { get; init; }

    public double CompareResult { get; init; }
}