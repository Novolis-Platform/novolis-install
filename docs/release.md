# Release

## Versioning

Tool versions are driven by `build/version.json` and shared Novolis MSBuild imports.

## Publishing

1. Tag or merge to `main` with green CI on `Novolis.Install.sln`
2. Pack publishes `Novolis.Install` to GitHub Packages
3. Users install via `dotnet tool install -g Novolis.Install`

## Artifacts

Releases ship the tool package, XML API documentation (for public helper types), symbols, and the package README at `src/Novolis.Install/README.md`.
