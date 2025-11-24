// © Copyright (c) V5iD, Inc. All right reserved.
// Licensed under the MIT.

namespace V5iD.PublicSdk.Models;

using System;
using System.Collections.Generic;
using V5iD.PublicSdk.Enums;

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