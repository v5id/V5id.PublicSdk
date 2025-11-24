// © Copyright (c) V5iD, Inc. All right reserved.
// Licensed under the MIT.

namespace V5iD.PublicSdk.Enums;

using System.Text.Json.Serialization;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum OverallMismatchType
{
    None = 0,
    
    Demographic = 1,
    
    Document = 2,
    
    Age = 3
}