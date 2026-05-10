// © Copyright (c) V5iD, Inc. All rights reserved.
// Licensed under the MIT.

using System.Text.Json;
using V5iD.PublicSdk.Enums;
using V5iD.PublicSdk.Models;

namespace PublicSdk.Tests;

public class IrAnalysisTests
{
    private static readonly JsonSerializerOptions Options = new(JsonSerializerDefaults.Web);

    [Fact]
    public void Verification_DefaultIrAnalysis_IsNull()
    {
        var verification = new Verification();

        Assert.Null(verification.IrAnalysis);
    }

    [Fact]
    public void IrAnalysis_NotEvaluated_RoundTripsThroughJson()
    {
        var analysis = new IrAnalysis { SummaryStatus = IrAnalysisSummaryStatus.NotEvaluated };

        var json = JsonSerializer.Serialize(analysis, Options);
        var roundTrip = JsonSerializer.Deserialize<IrAnalysis>(json, Options);

        Assert.Contains("\"summaryStatus\":\"NotEvaluated\"", json);
        Assert.NotNull(roundTrip);
        Assert.Equal(IrAnalysisSummaryStatus.NotEvaluated, roundTrip!.SummaryStatus);
        Assert.Null(roundTrip.Front);
        Assert.Null(roundTrip.Back);
    }

    [Fact]
    public void IrAnalysis_InvalidWithDetails_SerializesAllFields()
    {
        var analysis = new IrAnalysis
        {
            SummaryStatus = IrAnalysisSummaryStatus.Invalid,
            Front = new IrSideAnalysis
            {
                Valid = false,
                ValidationError = new IrValidationDetails
                {
                    TextPresent = ["United States of America", "Employment Authorization"],
                    TextMissing = [],
                    ImagePresent = ["Face image"],
                    ImageMissing = [],
                },
            },
            Back = new IrSideAnalysis
            {
                Valid = true,
                ValidationError = new IrValidationDetails(),
            },
        };

        var json = JsonSerializer.Serialize(analysis, Options);
        var roundTrip = JsonSerializer.Deserialize<IrAnalysis>(json, Options);

        Assert.NotNull(roundTrip);
        Assert.Equal(IrAnalysisSummaryStatus.Invalid, roundTrip!.SummaryStatus);
        Assert.NotNull(roundTrip.Front);
        Assert.False(roundTrip.Front!.Valid);
        Assert.Equal(2, roundTrip.Front.ValidationError.TextPresent.Count);
        Assert.Contains("United States of America", roundTrip.Front.ValidationError.TextPresent);
        Assert.Single(roundTrip.Front.ValidationError.ImagePresent);
        Assert.NotNull(roundTrip.Back);
        Assert.True(roundTrip.Back!.Valid);
    }

    [Fact]
    public void IrValidationDetails_Default_AllListsEmpty()
    {
        var details = new IrValidationDetails();

        Assert.Empty(details.TextPresent);
        Assert.Empty(details.TextMissing);
        Assert.Empty(details.ImagePresent);
        Assert.Empty(details.ImageMissing);
    }

    [Fact]
    public void Verification_WithIrAnalysis_RoundTripsThroughJson()
    {
        var verification = new Verification
        {
            VerificationUuid = "abc:def",
            ClientId = "client-1",
            IrAnalysis = new IrAnalysis
            {
                SummaryStatus = IrAnalysisSummaryStatus.Valid,
                Front = new IrSideAnalysis { Valid = true },
                Back = new IrSideAnalysis { Valid = true },
            },
        };

        var json = JsonSerializer.Serialize(verification, Options);
        var roundTrip = JsonSerializer.Deserialize<Verification>(json, Options);

        Assert.NotNull(roundTrip);
        Assert.NotNull(roundTrip!.IrAnalysis);
        Assert.Equal(IrAnalysisSummaryStatus.Valid, roundTrip.IrAnalysis!.SummaryStatus);
        Assert.Contains("\"irAnalysis\":", json);
    }
}
