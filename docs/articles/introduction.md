# Introduction

**PKDSIM** (repository `project_pkdsim`) is a Unity 6 (`6000.0.23f1`) game built
around a large catalogue of Pokémon-style NPCs. The codebase is organised as a
set of cooperating runtime *systems* that are discovered and started by a single
entry point, `USys`.

## Repository layout

This repository uses an unusual multi-branch layout:

| Branch | Contents |
| --- | --- |
| `main` | A thin aggregator: `.gitattributes`, `.gitmodules`, this `docs/` site, and the `PKDSIM/UnityAssets` **submodule** pointer. |
| `NMaster` | A full working copy of the Unity project (assets + source). |
| `Master` | Metadata-only snapshot (`.meta` files). |
| `UAssets-*`, `ULibruary-*`, `UPackagecache-*`, `USettings-*`, &hellip; | Per-area split branches (scripts, models, materials, package cache, project settings, etc.). |

The actual C# game code lives in the **`PKDSIM/UnityAssets`** submodule, which
points at the [`Pkdsim-Official/Unity_Assets`](https://github.com/Pkdsim-Official/Unity_Assets)
repository. Inside the submodule the project root is `PKDSIM/`, with source under
`PKDSIM/Assets/`.

## Where the code lives

All first-party C# is namespaced under `project_pkdsim.*` and is found in two
top-level areas of the Unity project:

- `PKDSIM/Assets/USys/` &mdash; the runtime systems (the heart of the game).
- `PKDSIM/Assets/Editor/` &mdash; editor-only tooling (the "workspaces").

Everything else under `Assets/` (`Library/PackageCache`, `Samples`, `Plugins`,
`TutorialInfo`, imported art packs) is third-party or generated and is excluded
from the API reference.

## How to read these docs

Start with the [Architecture overview](architecture.md) for the mental model,
then drill into [The USys bootstrap](usys-bootstrap.md) and the individual
[Subsystems](subsystems.md). The [Naming conventions](naming-conventions.md)
page is the decoder ring for the many abbreviations used throughout the source.
