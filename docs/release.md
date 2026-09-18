# Release

## Versioning

Tool versions are driven by `build/version.json` and shared Novolis MSBuild imports.

## Publishing

1. Change the host in `d:\novolis\novolis-tools\src\Novolis.Install`
2. Merge to `novolis-tools` with green CI
3. The tools workflow publishes `Novolis.Install` to GitHub Packages
4. Users install via `dotnet tool install -g Novolis.Install`

## Artifacts

Releases ship the tool package, XML API documentation (for public helper types),
symbols, and the package README in `novolis-tools`.
