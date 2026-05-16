# Design

- **Registry**: HTTPS-only JSON from [novolis-registry](https://github.com/Novolis-Platform/novolis-registry); no arbitrary install scripts.
- **Layout**: Per-user installs under `NovolisPaths.DataRoot`; shims in a user-writable bin directory.
- **CLI**: `System.CommandLine` with stable command names aligned to the bootstrap plan.
- **Distribution**: .NET global tool (`PackAsTool`, command name `novolis`).
