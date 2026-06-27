# Architecture overview

PKDSIM is built from a single orchestrator, **`USys`**, that owns a fixed set of
**subsystems**. Each subsystem is responsible for one slice of game behaviour
(money, dialogue, saving, teleporting, anti-cheat, &hellip;) and follows the same
structural pattern, which makes the codebase very regular once you know the shape.

## The big picture

```text
                         ┌───────────────────────────┐
                         │           USys            │   (MonoBehaviour)
                         │   project_pkdsim.Assets.  │
                         │           USys            │
                         └─────────────┬─────────────┘
                                       │ LoadUSys()
        ┌───────────┬───────────┬──────┴──────┬───────────┬───────────┐
        ▼           ▼           ▼             ▼           ▼           ▼
     AIRSys      MOSys       DialSys        UPSSys     ADATSys   …13 more
   (AI routes)  (money)     (dialogue)     (saving)  (anti-cheat)
        │
        └─ each subsystem: facade  →  base/impl in an `I/` folder  →  leaf logic
```

`USys` is a `MonoBehaviour` that holds one private field per subsystem and calls
its initialiser. See [The USys bootstrap](usys-bootstrap.md) for the exact order.

## The subsystem pattern

Almost every subsystem is expressed as **three layers**:

1. **Facade** &mdash; a small public class named with the subsystem's short code
   (e.g. `MOSys`, `DialSys`, `SCMSys`). It exposes a single public initialiser
   method and delegates straight to the layer below. This is the type `USys`
   holds a reference to.
2. **Implementation base (`I/`)** &mdash; a class in an `I` sub-folder (suffixed
   `...SysI`, e.g. `MoneySysI`, `ADATSysI`) that contains the orchestration
   logic and references the leaf components.
3. **Leaf components** &mdash; deeper folders holding the concrete behaviour
   (individual NPC animators, teleport waypoints, time-manipulation checks, &hellip;).

```csharp
// Layer 1 — facade (PKDSIM/Assets/USys/MOSys/I/MoneySys/MoneySys.cs)
namespace project_pkdsim.Assets.USys.MoneySys
{
    public class MOSys : MoneySysI          // derives from the impl base
    {
        public void MoneySysI() => MoneySys_I();   // delegates downward
    }
}
```

> [!NOTE]
> The folder name (`MOSys`), the namespace tail (`MoneySys`), the facade type
> (`MOSys`) and the init method (`MoneySysI`) are all *related but not identical*
> spellings of the same concept. The [Naming conventions](naming-conventions.md)
> page maps them all.

## Folder conventions

- `PKDSIM/Assets/USys/<CODE>Sys/` &mdash; one folder per subsystem (`MOSys`,
  `ADATSys`, &hellip;).
- `.../I/` &mdash; "implementation" folder holding the base class and deeper logic.
- Pokémon-named leaf folders (`flareon/`, `sylveon/`, `umbreon/`, &hellip;) hold
  per-NPC behaviour, most visibly under `AIRSys` (animation data) and `FSSys`
  (animation fail-safes).

## Notable cross-cutting systems

- **`AIRSys`** (AI Routes) is the largest subsystem &mdash; it drives per-NPC
  animation data and animator controllers for the full creature roster.
- **`FSSys`** (Fail-Safe) provides animator/voice-actor fail-safes. Unlike the
  others it is *not* started from `USys.LoadUSys()`; it stands on its own.
- **`ADATSys`** (Anti Date-And-Time) is an anti-cheat system that detects system
  clock manipulation across play sessions.

Continue to [The USys bootstrap](usys-bootstrap.md) for the load sequence, or
jump to [Subsystems](subsystems.md) for a per-system reference.
