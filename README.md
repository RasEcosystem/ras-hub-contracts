[English](README.md) | [Русский](README.ru.md)

# RasHub.Contracts

Versioned request, response, pagination, and API-envelope types shared by
RasHub clients and servers. The library contains only shared API models and
does not reference the RasHub server implementation.

## Related projects

RasHub.Contracts is part of the [Ras Ecosystem](https://github.com/RasEcosystem):

- [RasStudio Mono](https://github.com/RasEcosystem/ras-studio-mono) — an
  experimental desktop client for single-user RAS administration;
- [RasHub](https://github.com/RasEcosystem/ras-hub) — the central service for
  infrastructure management and a unified API;
- [RasGate](https://github.com/RasEcosystem/ras-gate) — a gateway for controlled
  RAC command execution over HTTP.

## Use as a submodule

```bash
git submodule add \
  https://github.com/RasEcosystem/ras-hub-contracts.git \
  src/RasHub.Contracts

dotnet add <project.csproj> reference \
  src/RasHub.Contracts/src/RasHub.Contracts/RasHub.Contracts.csproj
```

After cloning a consumer:

```bash
git submodule update --init --recursive
```

Licensed under the [MIT License](LICENSE).
