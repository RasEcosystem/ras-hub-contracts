# RasHub.Contracts

A shared API contracts library.

## Purpose

The library provides shared request and response models, avoiding duplication across consuming projects.

## Requirements

- .NET SDK 10.0 or later.

## Setup

Add the library as a Git submodule:

```bash
git submodule add https://github.com/zmaxb/ras-hub-contracts.git submodules/RasHub.Contracts
```

Reference it from the consuming project:

```bash
dotnet add <path-to-project.csproj> reference \
  submodules/RasHub.Contracts/src/RasHub.Contracts/RasHub.Contracts.csproj
```

After cloning a consuming repository, initialize the submodule:

```bash
git submodule update --init --recursive
```

## Updating

Update the submodule and commit its new revision:

```bash
git submodule update --remote submodules/RasHub.Contracts
git add submodules/RasHub.Contracts
git commit -m "Update RasHub.Contracts"
```

## License

Licensed under the MIT License. See [LICENSE](LICENSE).
