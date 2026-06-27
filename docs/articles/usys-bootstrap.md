# The USys bootstrap

`USys` (`project_pkdsim.Assets.USys.USys`) is the single orchestrator that wires
the game's runtime systems together. It is a `MonoBehaviour` and lives at
`PKDSIM/Assets/USys/USys.cs`.

## Responsibilities

- Hold one private field per subsystem (its facade type).
- Start every subsystem from a single method, `LoadUSys()`, by calling that
  subsystem's `Load<Code>Sys()` helper, which in turn calls the subsystem's own
  initialiser.

## The load sequence

`LoadUSys()` calls the per-subsystem loaders in this fixed order:

| # | Loader on `USys` | Field type | Initialiser called |
| --- | --- | --- | --- |
| 1 | `LoadAIRSys()` | `AIRSys` | `AIRSys.AIRoutesSysI()` |
| 2 | `LoadHDSys()` | `HDSys` | `HolidaySys.HDSysI()` |
| 3 | `LoadITEMSSys()` | `ITEMSys` | `ItemsSys.ITEMSSysI()` |
| 4 | `LoadLOVESys()` | `LOVERSys` | `LoveSys.LoveSysI()` |
| 5 | `LoadUPSSys()` | `UPSSys` | `UPSSys.UPSSysI()` |
| 6 | `LoadTCMSys()` | `TCMSys` | `TCMSys.TCMSysI()` |
| 7 | `LoadTABSys()` | `TABSys` | `TABSys.TABSysI()` |
| 8 | `LoadSCMSys()` | `SCMSys` | `SCMSys.SCMSysI()` |
| 9 | `LoadMoneySys()` | `MOSys` | `MoneySys.MoneySysI()` |
| 10 | `LoadHTPSys()` | `UnityTeleporterSys` | `UTPSys.UTPSysI()` |
| 11 | `LoadDialogueSys()` | `DialSys` | `DialogueSys.DialogueSysI()` |
| 12 | `LoadAudioSys()` | `AudioSys` | `AudioSys.AudioSysI()` |
| 13 | `LoadADATSys()` | `ADATSys` | `ADATSys.ADATSysI()` |
| 14 | `LoadATSys()` | `ATSys` | `ATSys.ATSysI()` |
| 15 | `LoadSBSys()` | `SBSys` | `SBSys.SBSysI()` |

> [!NOTE]
> The order in `LoadUSys()` differs slightly from the order in which the fields
> are declared at the top of the class. The table above reflects the **call
> order**, which is what actually runs.

## Shape of a loader

Each `Load<Code>Sys()` method is a one-liner that forwards to the subsystem
facade's initialiser:

```csharp
private void LoadMoneySys()
{
    MoneySys.MoneySysI();
}
```

The facade then delegates to its implementation base (see
[Architecture overview](architecture.md#the-subsystem-pattern)), and from there
into the leaf logic.

## Systems started elsewhere

`FSSys` (Fail-Safe) is **not** part of `LoadUSys()`. It is a standalone
`MonoBehaviour` that aggregates `VoiceActorsFailSafetySys` and
`AnimatorFailSafetySys` and is initialised independently of `USys`.

For a description of what each subsystem actually does, see
[Subsystems](subsystems.md).
