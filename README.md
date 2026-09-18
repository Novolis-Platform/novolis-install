<!-- novolis-marketing:start -->
<p align="center">
  <a href="https://github.com/Novolis-Platform">
    <img src="https://raw.githubusercontent.com/Novolis-Platform/.github/main/brand/logo-brand-transparent.svg" width="360" alt="Novolis"/>
  </a>
</p>

<p align="center">
  <img src="https://raw.githubusercontent.com/Novolis-Platform/.github/main/brand/banners/novolis-install.svg" width="100%" alt="novolis-install"/>
</p>

<p align="center">
  <strong>Archived installer host</strong><br/>
  The `novolis` tool host moved to novolis-tools.
</p>

<p align="center">
  <a href="https://novolis-platform.github.io/.github/novolis-install/"><img src="https://img.shields.io/badge/docs-portfolio-0a7ea3" alt="docs"/></a>
  <a href="https://github.com/Novolis-Platform/novolis-install/actions"><img src="https://img.shields.io/github/actions/workflow/status/Novolis-Platform/novolis-install/merge.yml?branch=main&label=merge&logo=github" alt="merge"/></a>
  <a href="https://github.com/orgs/Novolis-Platform/packages?repo_name=novolis-install"><img src="https://img.shields.io/badge/packages-GitHub%20Packages-0a7ea3?logo=nuget" alt="packages"/></a>
  <a href="https://github.com/Novolis-Platform"><img src="https://img.shields.io/badge/org-Novolis--Platform-111827" alt="org"/></a>
</p>

<p align="center">
  <a href="https://novolis-platform.github.io/.github/novolis-install/">Docs</a>
  ·
  <a href="https://nuget.pkg.github.com/Novolis-Platform/index.json"><code>https://nuget.pkg.github.com/Novolis-Platform/index.json</code></a>
  ·
  <a href="https://github.com/Novolis-Platform/.github/blob/main/profile/README.md">Org landing</a>
  ·
  <a href="https://github.com/Novolis-Platform/novolis-governance">Governance</a>
</p>

---
<!-- novolis-marketing:end -->
<!-- novolis-package-index:start -->
> **GitHub Packages shows this repository README on every package page** (upstream limitation).
> Open the **package README** for install and quick start — embedded in each .nupkg and linked below.

## Published packages

| Package | Install | Package README |
|---------|---------|----------------|
| `Novolis.Install` | Published from [`novolis-tools`](https://github.com/Novolis-Platform/novolis-tools) | [tool README](https://github.com/Novolis-Platform/novolis-tools/tree/main/src/Novolis.Install) |

For NuGet.org and Visual Studio, the **embedded** README.md inside each package is authoritative.

<!-- novolis-package-index:end -->
# novolis-install (archived host repository)

The `novolis` executable host moved to
[`novolis-tools`](https://github.com/Novolis-Platform/novolis-tools) so
`PackAsTool` publishing is unified. This repository no longer contains a
packable executable project.

## Package

| Package | Description |
|---------|-------------|
| [Novolis.Install](https://github.com/Novolis-Platform/novolis-tools/tree/main/src/Novolis.Install) | Global tool CLI (`search`, `doctor`, `install`, …) |

Restore and publish via **nuget.org** and **GitHub Packages** only. For local platform library work, use **`Novolis.Platform.slnx`** (ProjectReference mode) — not sibling-repo hacks in this tool project.

## What it is

`Novolis.Install` remains the user-facing CLI for the Novolis ecosystem, but
its source and publishing workflow live in `novolis-tools`.

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

