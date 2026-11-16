// © Copyright (c) V5iD, Inc. All rights reserved.
// Licensed under the MIT.

namespace V5iD.PublicSdk.Models;

/// <summary>
/// What Document AI identified a document as, broken out of its classifier label.
/// <para>
/// The parts are text rather than enums for the same reason <see cref="MrzDetail"/> keeps its fields
/// as text: the classifier's vocabulary grows independently of this package, and a value we have not
/// heard of yet should still reach the caller instead of being flattened to "Unknown".
/// </para>
/// <para>
/// The raw classifier label is deliberately not exposed: it also carries the image's side and
/// lighting, which are internal to recognition. Only the parts meant to be shown appear here.
/// </para>
/// </summary>
public class DocumentClassifierDetail
{
    /// <summary>The issuing country, e.g. "USA", "MEX".</summary>
    public string? Country { get; init; }

    /// <summary>
    /// The issuing subdivision, e.g. "CA", "ON". Null when the document has none — there is then no
    /// subdivision row to show.
    /// </summary>
    public string? Subdivision { get; init; }

    /// <summary>The issuing authority, e.g. "USDeptState", "SRE".</summary>
    public string? Issuer { get; init; }

    /// <summary>The kind of document, e.g. "Passport", "DriverLicense".</summary>
    public string? Category { get; init; }

    /// <summary>The physical shape, e.g. "Booklet", "Card".</summary>
    public string? Format { get; init; }

    /// <summary>The variant, e.g. "Standard", "Diplomatic".</summary>
    public string? SubType { get; init; }

    /// <summary>The design year, e.g. "2021".</summary>
    public string? Version { get; init; }

    /// <summary>How confident the classifier is, 0..1 — shown as the percentage beside the identification.</summary>
    public float Score { get; init; }
}
