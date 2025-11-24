// © Copyright (c) V5iD, Inc. All rights reserved.
// Licensed under the MIT.

namespace V5iD.PublicSdk.Models;

using System;
using System.Collections.Generic;

public class Demographic
{
    public Guid DemographicUuid { get; init; }

    public required string FirstName { get; init; }

    public string? MiddleName { get; init; }

    public required string LastName { get; init; }

    public DateTimeOffset? DateOfBirth { get; init; }

    public Address? Address { get; init; }

    public IList<Phone>? Phones { get; init; }

    public IList<Email>? Emails { get; init; }

    public string? Ssn { get; init; }

    public IList<DemographicAnalyzer>? DemographicAnalysis { get; init; }
}