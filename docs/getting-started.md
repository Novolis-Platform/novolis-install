# Getting started

Install the **Novolis.Install** global tool to search the Novolis registry, inspect packages, and manage local installs.

## Prerequisites

- [.NET 10 SDK](https://dotnet.microsoft.com/download)

## Install the tool

```bash
dotnet tool install -g Novolis.Install
```

Verify:

```bash
novolis doctor
```

## Common commands

| Command | Description |
|---------|-------------|
| `novolis search [term]` | List packages from the registry index |
| `novolis info <id>` | Show package metadata (partial) |
| `novolis install <id>` | Install a package (in progress) |
| `novolis list` | List locally installed packages |
| `novolis doctor` | Print paths and environment checks |

## Build from source

```bash
dotnet build Novolis.Install.sln
dotnet run --project src/Novolis.Install -- doctor
```

## See also

- [Design](design.md)
- [Release](release.md)
