---
_layout: landing
---

# PKDSIM Documentation

Welcome to the documentation for **PKDSIM** (`project_pkdsim`), a Unity 6 game
project. This site has two halves:

- **[Articles](articles/introduction.md)** &mdash; hand-written conceptual docs
  that explain the architecture: how the central `USys` bootstrap works, what
  each subsystem does, the editor tooling, and the project's naming conventions.
- **[API Reference](api/index.md)** &mdash; the C# API reference generated
  directly from the source code in the `PKDSIM/UnityAssets` submodule.

## Start here

| If you want to&hellip; | Go to |
| --- | --- |
| Understand the big picture | [Architecture overview](articles/architecture.md) |
| See how systems are started at runtime | [The USys bootstrap](articles/usys-bootstrap.md) |
| Learn what an individual system does | [Subsystems](articles/subsystems.md) |
| Understand the editor-only tooling | [Editor workspaces](articles/editor-workspaces.md) |
| Decode the abbreviations in the code | [Naming conventions](articles/naming-conventions.md) |
| Rebuild this site yourself | [Building the docs](articles/building-docs.md) |
| Browse types & members | [API Reference](api/index.md) |

> [!NOTE]
> The game's C# source does not live on the `main` branch directly &mdash; it is
> pulled in through the `PKDSIM/UnityAssets` git submodule. The API reference is
> generated from that submodule, so it must be checked out before building (see
> [Building the docs](articles/building-docs.md)).
