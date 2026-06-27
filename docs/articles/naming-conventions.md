# Naming conventions

The codebase leans heavily on short codes and a few recurring suffixes. Once you
internalise these, the structure is predictable.

## The four spellings of a system

For any one subsystem you will see up to four related-but-different spellings:

| Thing | Example | Notes |
| --- | --- | --- |
| Folder / short code | `MOSys` | What you see under `Assets/USys/`. |
| Namespace tail | `MoneySys` | The descriptive name. |
| Facade class | `MOSys` (or `LOVERSys`, `DialSys`) | The public type `USys` holds. |
| Initialiser method | `MoneySysI()` | The public entry point called by `USys`. |

They are intentionally similar but rarely identical &mdash; don't assume the
folder name equals the class name. See the mapping table in
[Subsystems](subsystems.md).

## Recurring suffixes

| Suffix | Meaning |
| --- | --- |
| `...Sys` | A system (runtime subsystem or sub-component). |
| `...SysI` | The **implementation base** of a system, found in an `I/` folder. Also used as the name of a system's **initialiser method**. |
| `...I` (folder) | "Implementation" folder holding the base class + deeper logic. |
| `..._I()` | A private/internal "run the implementation" method on a base class (e.g. `ADATSys_I()`, `MoneySys_I()`). |

## Short codes

| Code | Expands to |
| --- | --- |
| `AIR` | AI Routes |
| `ADAT` | Anti Date-And-Time |
| `AT` | Animated Textures |
| `HD` | Holiday |
| `ITEMS` | Items |
| `LOVE` / `LOVER` | Love (relationships) |
| `MO` | Money |
| `SB` | Skybox |
| `SCM` | Scene Manager |
| `TAB` | Tabs (PkPhone) |
| `TCM` | Tab Change Manager |
| `UPS` | Unity Player Save |
| `UTP` / `UHTP` | Unity (House) Teleporter |
| `FS` / `AFS` / `VAFS` | Fail-Safe / Animator Fail-Safe / Voice-Actor Fail-Safe |
| `D` / `Dial` | Dialogue |

## NPC abbreviations

Per-creature leaf classes use two-letter prefixes, e.g. `Fl_Animator` (Flareon),
`Es_Animator` (Espeon), `Um_*` (Umbreon), `Sy_*`/`SYL_*` (Sylveon), `Vp_*`
(Vaporeon), `Z_*` (Zoroark). The full creature roster appears under both
`AIRSys/` (animation data) and `FSSys/` (animation fail-safes).

## Namespace root

All first-party code is rooted at `project_pkdsim.Assets.*`. The docs' API filter
(`docs/filterConfig.yml`) uses this prefix to include only project code and drop
third-party/engine symbols.
