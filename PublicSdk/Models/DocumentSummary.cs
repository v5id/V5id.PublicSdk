// © Copyright (c) V5iD, Inc. All rights reserved.
// Licensed under the MIT.

namespace V5iD.PublicSdk.Models;

using System.Collections.Generic;

public record DocumentSummary(IList<AnalysisGroup> AnalysisGroups)
{
    /// <summary>
    /// What Document AI identified the document as, once its sides have been reconciled — the
    /// "whole" half of the Document summary identification.
    /// <para>
    /// Null when no side was identified, and also when the sides describe different documents: there
    /// is then no single answer to show.
    /// </para>
    /// </summary>
    public DocumentClassifierDetail? ClassifierDetail { get; init; }
}
