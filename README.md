# PKDSIM (`project_pkdsim`)

A Unity 6 (`6000.0.23f1`) game built around a catalogue of Pokémon-style NPCs.
The runtime is organised as a set of cooperating *systems* started by a single
orchestrator, `USys`.

## Repository layout

This repo uses a multi-branch layout. The `main` branch is a thin aggregator:

```
.
├── .gitmodules            # registers the PKDSIM/UnityAssets submodule
├── docs/                  # DocFX documentation site (articles + API reference)
├── Makefile               # `make docs`
├── build.ps1              # Windows docs build (no make required)
└── PKDSIM/
    └── UnityAssets/       # git submodule -> Pkdsim-Official/Unity_Assets
        └── PKDSIM/        # the actual Unity project (Assets, ProjectSettings, ...)
```

The C# game code lives in the **`PKDSIM/UnityAssets`** submodule. Other branches
(`NMaster`, `Master`, `UAssets-*`, `ULibruary-*`, `UPackagecache-*`, &hellip;)
hold full or per-area copies of the Unity project.

Get the source:

```bash
git clone https://github.com/Pkdsim-Official/project_pkdsim.git
cd project_pkdsim
git submodule update --init --depth 1 PKDSIM/UnityAssets
```

## Documentation

Full architecture docs and a generated C# API reference are in [`docs/`](docs/).

Build the site:

```bash
make docs        # Linux/macOS (or Windows with GNU make)
# or
./build.ps1      # Windows / any PowerShell
```

The rendered site is written to `docs/_site/`. See
[`docs/articles/building-docs.md`](docs/articles/building-docs.md) for details,
prerequisites, and how to enable the CI workflow
([`docs/ci/docs.yml.sample`](docs/ci/docs.yml.sample)) that publishes the site to
GitHub Pages.

### What's documented

- **Architecture overview** &mdash; the `USys` orchestrator and the subsystem
  pattern.
- **The USys bootstrap** &mdash; the exact subsystem load order.
- **Subsystems** &mdash; per-system reference (AIRSys, ADATSys, MOSys, DSys,
  UPSSys, SCMSys, TABSys, TCMSys, UTPSys, HDSys, ITEMSSys, LOVESys, ATSys, SBSys,
  AUDIOSys, FSSys).
- **Editor workspaces** &mdash; the editor-only tooling.
- **Naming conventions** &mdash; the decoder ring for the project's short codes.
- **API reference** &mdash; generated from the submodule source with DocFX.
