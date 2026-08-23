[English](README.md) | [Русский](README.ru.md)

# RasHub.Contracts

Версионируемые типы запросов, ответов, пагинации и оболочек API, общие для
клиентов и серверов RasHub. Библиотека содержит только общие модели API и не
ссылается на серверную реализацию RasHub.

## Связанные проекты

RasHub.Contracts входит в [Ras Ecosystem](https://github.com/RasEcosystem):

- [RasStudio Mono](https://github.com/RasEcosystem/ras-studio-mono) —
  экспериментальный настольный клиент для индивидуального администрирования
  RAS;
- [RasHub](https://github.com/RasEcosystem/ras-hub) — центральный сервис для
  управления инфраструктурой и предоставления единого API;
- [RasGate](https://github.com/RasEcosystem/ras-gate) — шлюз для контролируемого
  выполнения команд RAC по HTTP.

## Использование в качестве подмодуля

```bash
git submodule add \
  https://github.com/RasEcosystem/ras-hub-contracts.git \
  src/RasHub.Contracts

dotnet add <project.csproj> reference \
  src/RasHub.Contracts/src/RasHub.Contracts/RasHub.Contracts.csproj
```

После клонирования проекта, использующего контракты:

```bash
git submodule update --init --recursive
```

Проект распространяется по [лицензии MIT](LICENSE).
