// © Copyright (c) V5iD, Inc. All right reserved.
// Licensed under the MIT.

namespace V5iD.PublicSdk.Enums;

using System.Text.Json.Serialization;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum DemographicAnalysisType
{
    None = 0,
    
    FirstName = 1,
    
    MiddleName = 2,
    
    LastName = 3,
    
    DateOfBirth = 4,
    
    Street = 5,
    
    City = 6,
    
    State = 7,
    
    PostalCode = 8,
    
    Country = 9
}