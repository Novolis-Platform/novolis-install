<!-- novolis-package-index:start -->
> **GitHub Packages shows this repository README on every package page** (upstream limitation).
> Open the **package README** for install and quick start — embedded in each .nupkg and linked below.

## Published packages

| Package | Install | Package README |
|---------|---------|----------------|
| `Novolis.Install` | `dotnet tool install -g Novolis.Install` | [README](https://github.com/Novolis-Platform/novolis-install/blob/main/src/Novolis.Install/README.md) |

For NuGet.org and Visual Studio, the **embedded** README.md inside each package is authoritative.

<!-- novolis-package-index:end -->

# novolis-install

Cross-platform **`novolis`** [.NET global tool](https://learn.microsoft.com/dotnet/core/tools/global-tools) for searching, installing, and managing packages from the [Novolis registry](https://github.com/Novolis-Platform/novolis-registry).

## Package

| Package | Description |
|---------|-------------|
| [Novolis.Install](src/Novolis.Install/README.md) | Global tool CLI (`search`, `doctor`, `install`, …) |

Restore and publish via **nuget.org** and **GitHub Packages** only. For local platform library work, use **`Novolis.Platform.slnx`** (ProjectReference mode) — not sibling-repo hacks in this tool project.

## What it is

`Novolis.Install` is the user-facing CLI for the Novolis ecosystem. It reads the static registry, installs into per-user locations, and will integrate with platform installers (Inno on Windows) over time.

## Current status

**v0.1.0** — initial publish. Core commands exist; `install` / `update` / `remove` are stubs. `search`, `info`, `list`, and `doctor` are functional at a basic level.

## Install

```bash
dotnet tool install --global Novolis.Install
```

Preview channel (when published):

```bash
dotnet tool install --global Novolis.Install --version 0.2.0-preview.1
```

Update:

```bash
dotnet tool update --global Novolis.Install
```

## Quick start

```bash
novolis doctor
novolis search
novolis info example-tool
```

## Install locations

| OS | Data | Shims |
|----|------|-------|
| Windows | `%LOCALAPPDATA%\Novolis` | `%USERPROFILE%\.novolis\bin` |
| Linux | `~/.local/share/novolis` | `~/.local/bin` or `~/.novolis/bin` |
| macOS | `~/Library/Application Support/Novolis` | `~/.novolis/bin` |

## Documentation

- [Getting started](docs/getting-started.md)
- [Design](docs/design.md)
- [Release](docs/release.md)

## Contributing

See [CONTRIBUTING.md](CONTRIBUTING.md).

## Security

See [SECURITY.md](SECURITY.md).

## Publishing (maintainers)

Publishing uses [NuGet trusted publishing](https://learn.microsoft.com/nuget/nuget-org/trusted-publishing) from GitHub Releases only.

1. Add trusted publishing on [NuGet Novolis org](https://www.nuget.org/organization/Novolis) for this repo (`release.yml`, environment `nuget.org`).
2. Bump `<Version>` in `Novolis.Install.csproj` to match the git tag (e.g. `v0.1.0`).
3. Create a [GitHub Release](https://github.com/Novolis-Platform/novolis-install/releases/new) with that tag.
4. Approve the `nuget.org` environment deployment.
