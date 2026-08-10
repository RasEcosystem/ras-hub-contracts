# RasHub.Contracts

Versioned request, response, pagination, and API-envelope types shared by
RasHub clients and servers. The project has no dependency on server
implementation assemblies.

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

Contract changes are compatibility-sensitive. Prefer additive changes and
update serialization tests with the affected models.

Licensed under the [MIT License](LICENSE).
