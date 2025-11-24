// © Copyright (c) V5iD, Inc. All rights reserved.
// Licensed under the MIT.

namespace V5iD.PublicSdk.Models;

using System;
using System.Collections.Generic;

public class DocumentRecognition
{
    public Guid RecognizedDocumentUuid { get; init; }

    public Address? Address { get; init; }
    public float AddressConfidence { get; init; }

    public string? CountryRegion { get; init; }
    public float CountryRegionConfidence { get; init; }

    public DateTimeOffset? DateOfBirth { get; init; }
    public float DateOfBirthConfidence { get; init; }

    public DateTimeOffset? DateOfExpiration { get; init; }
    public float DateOfExpirationConfidence { get; init; }

    public string? DocumentNumber { get; init; }
    public float DocumentNumberConfidence { get; init; }
        
    public string? DocumentDiscriminator { get; init; }
    public float DocumentDiscriminatorConfidence { get; init; }

    public string? FirstName { get; init; }
    public float FirstNameConfidence { get; init; }
        
    public string? MiddleName { get; init; }
    public float MiddleNameConfidence { get; init; }

    public string? LastName { get; init; }
    public float LastNameConfidence { get; init; }

    public string? Region { get; init; }
    public float RegionConfidence { get; init; }

    public string? Sex { get; init; }
    public float SexConfidence { get; init; }
        
    public string? DocumentType { get; init; }
        
    public string? DateOfIssue { get; init; }
        
    public float DateOfIssueConfidence { get; init; }

    public string? MrzString { get; init; }
    public MrzDetail? MrzDetailResponse { get; init; }
        
    public IList<AnalysisGroup>? AnalysisGroups { get; init; }
}