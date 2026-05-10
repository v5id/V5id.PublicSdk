// © Copyright (c) V5iD, Inc. All rights reserved.
// Licensed under the MIT.

namespace V5iD.PublicSdk.Models;

using System.Collections.Generic;

public class IrValidationDetails
{
    public IList<string> TextPresent { get; init; } = [];

    public IList<string> TextMissing { get; init; } = [];

    public IList<string> ImagePresent { get; init; } = [];

    public IList<string> ImageMissing { get; init; } = [];
}
