// © Copyright (c) V5iD, Inc. All rights reserved.
// Licensed under the MIT.

using V5iD.PublicSdk.Attributes;

namespace V5iD.PublicSdk.Enums
{
    public enum AnalysisGroup
    {
        [GroupMetadata("Document Analysis", "Checks if basic document details like name, number, and dates are identified.", 1)]
        DocumentAnalysis,

        [GroupMetadata("Authenticity Analysis", "Ensures the document's integrity and verifies if it's genuine.", 2)]
        AuthenticityAnalysis,

        [GroupMetadata("MRZ Analysis", "Validates the Machine Readable Zone (MRZ) for format and checksum.", 3)]
        MrzAnalysis,
    }
}