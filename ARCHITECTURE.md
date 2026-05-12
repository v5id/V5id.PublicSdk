# V5id.PublicSdk — SDK architecture

Part of the [V5iD platform](../ARCHITECTURE.md). See root for cross-service overview. See [V5id.Sdk](../V5id.Sdk/ARCHITECTURE.md) for the internal-SDK family and version drift discussion.

## Role
The customer-facing SDK published to **nuget.org as `V5iD.PublicSdk`**. This is what an integrator installs.

## Surface
Single `IV5iDClient` / `V5iDClient` HTTP client. Namespaces: `V5iD.PublicSdk.Clients`, `.Models`, `.Enums`, `.Helpers`, `.Options`.

~43 model classes including:
- `Verification`, `CreatedVerification`, `CreatedWebVerification`, `VerificationStatus`
- `OperationResult<T>` (success/failure envelope — every HTTP call returns this)
- `FaceCompare`, `SignatureDetail`, `BarcodeDetail`, `DocumentRecognition`
- `Demographic`, `LivenessVerificationStatus`
- `BarcodePdf417`, `MrzDetail`, `DemographicAnalyzer`

Auth via `TokenRequest` / `TokenResponse` (API key style).

Strong typing on enums: `FileType`, `VerifyStatus`, `VerificationProcessingStatus`. `VerificationProcessingStatus.NotApplicable = 7` is the terminal per-file face-state used when a document side has no detectable face (Face.Api publishes `NoFaceFoundOnDocument`, Customer.Api persists `NotApplicable`).

`FaceComparisonSection` carries `Tooltip`, `FaceCompareResults`, and `HighestMatch` (the best compare across the section). `DocumentRecognition.FaceComparisonSection` is per-document — populated by Customer.Api with compares whose source/target upload-file matches that document.

## Tech
.NET 8 (single TFM), minimal external deps (`Microsoft.AspNetCore.WebUtilities` 8.0.0, `Microsoft.Extensions.Options` 8.0.0).

## Versioning
**Canonical version is built in CI, not from source.** The `1.0.0` literal in `GlobalAssemblyInfo.cs` is non-canonical and should be ignored. `dotnet pack -p:PackageVersion=$SDK_VERSION$BETA.$BUILD_NUMBER` stamps the real version.

The internal `V5id.Sdk.Messaging` references `V5iD.PublicSdk 1.2.1.16` — that is the actual published version it builds against.

## Publish target
[nuget.org/packages/V5iD.PublicSdk](https://www.nuget.org/packages/V5iD.PublicSdk/), MIT-licensed.

## Tests
`PublicSdk.Tests`.

## Gotchas
- **Models in `V5iD.PublicSdk.Models` are consumed both by integrators AND internally** (e.g. `Barcode.Api` returns `BarcodePdf417`). Changes here are simultaneously customer-facing and internal-facing — a major bump is a coordinated release across every backend.
- **`V5id.Sdk.Messaging` transitively imports `V5iD.PublicSdk`** — bumping PublicSdk invalidates every consumer of the messaging contracts even when they didn't intend to upgrade. See [V5id.Sdk](../V5id.Sdk/ARCHITECTURE.md) for the coupling discussion.
- **Append-only enums.** Adding a value in the middle of `VerifyStatus` / `FileType` / `VerificationProcessingStatus` reorders DB results when consumers `OrderByDescending` over enum columns. Never reorder.
