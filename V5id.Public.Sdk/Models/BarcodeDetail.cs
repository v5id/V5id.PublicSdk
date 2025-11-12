namespace V5id.Public.Sdk.Models;

public class BarcodeDetail
{
    public Guid BarcodeUuid { get; init; }

    public BarcodePdf417Formatted FormattedBarcode { get; init; } = new();
    
    public ICollection<BarcodeAnalysisGroup>? BarcodeAnalysis { get; init; }
}