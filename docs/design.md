# Design

## Package

**Novolis.Install** is a `PackAsTool` executable (`novolis` command) built on `System.CommandLine`.

## Layout

| Area | Responsibility |
|------|----------------|
| `Commands/CommandBuilder` | CLI command tree |
| `Paths/NovolisPaths` | Cross-platform data, shim, and state paths |
| `Registry/` | HTTP fetch and JSON deserialization of `index.json` |

## Registry

The default index URL is defined in `RegistryOptions.DefaultIndexUrl` and points at the Novolis-Platform registry repository.

## Local state

Installed package metadata is intended to live under `NovolisPaths.DataRoot` with `state.json` tracking versions. Install/remove flows are still being implemented.
