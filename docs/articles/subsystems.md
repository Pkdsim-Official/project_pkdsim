# Subsystems

Every subsystem lives under `PKDSIM/Assets/USys/<CODE>Sys/` and exposes a facade
class that `USys` initialises. This page summarises each one. For the exact
members, follow the API links into the [API Reference](../api/index.md).

| Code | Folder | Namespace | Facade class | Initialiser |
| --- | --- | --- | --- | --- |
| AIRSys | `AIRSys/` | `AIRoutesSys` | `AIRSys` | `AIRoutesSysI()` |
| HDSys | `HDSys/` | `HolidaySys` | `HDSys` | `HDSysI()` |
| ITEMSSys | `ITEMSSys/` | `USystemsSys` | `ITEMSys` | `ITEMSSysI()` |
| LOVESys | `LOVESys/` | `LoveSys` | `LOVERSys` | `LoveSysI()` |
| UPSSys | `UPSSys/` | `UnityPlayerSaveSys` | `UPSSys` | `UPSSysI()` |
| TCMSys | `TCMSys/` | `TabChangeManagerSys` | `TCMSys` | `TCMSysI()` |
| TABSys | `TABSys/` | `TabSys` | `TABSys` | `TABSysI()` |
| SCMSys | `SCMSys/` | `SceneManagerSys` | `SCMSys` | `SCMSysI()` |
| MOSys | `MOSys/` | `MoneySys` | `MOSys` | `MoneySysI()` |
| UTPSys | `UTPSys/` | `UTeleporterSys` | `UnityTeleporterSys` | `UTPSysI()` |
| DSys | `DSys/` | `DialogueSys` | `DialSys` | `DialogueSysI()` |
| AUDIOSys | `AUDIOSys/` | `AUDIOSys` | `AudioSys` | `AudioSysI()` |
| ADATSys | `ADATSys/` | `AntiDateAndTimeSys` | `ADATSys` | `ADATSysI()` |
| ATSys | `ATSys/` | `AnimatedTexturesSys` | `ATSys` | `ATSysI()` |
| SBSys | `SBSys/` | `SkyboxSys` | `SBSys` | `SBSysI()` |
| FSSys | `FSSys/` | `FSSys` | `FSSys` | `FSSysI()` (standalone) |

---

## AIRSys &mdash; AI Routes

The largest subsystem. It owns NPC animation data and animator controllers for
the full creature roster. The facade `AIRSys.AIRoutesSysI()` calls
`NPC_AniData("AniData")`, which drives `AIRSys_NPCAnimation_Data` to load each
creature's animation data. Leaf folders are organised per creature
(`flareon/`, `sylveon/`, `umbreon/`, &hellip;), each with idle / transition /
movement animation data and a dedicated animator (e.g. `Fl_Animator`,
`Es_Animator`).

## ADATSys &mdash; Anti Date-And-Time (anti-cheat)

Detects manipulation of the system clock across play sessions. The base
`ADATSysI` orchestrates three leaf components in order:

1. `Load_Play_History` &mdash; load the persisted play history.
2. `Check_For_Time_Manipulation` &mdash; compare against the current clock.
3. `Save_Current_Play_Date` &mdash; persist the current date for next time.

A `HandleTimeCheating` component handles the response when tampering is detected.

## UPSSys &mdash; Unity Player Save

Owns persistence. The facade `UPSSys` derives from `UnityPlayerSaveFIleSys`; its
`UPSSysI()` runs the save-file initialisation (`UPSSys_I()`).

## SCMSys &mdash; Scene Manager

Thin wrapper over Unity's `SceneManager`. `SCMSysI()` calls `LoadScene(...)` to
load the main `project_pkdsim` scene.

## MOSys &mdash; Money

In-game currency system. `MoneySysI()` delegates to `MoneySys_I()` in the
implementation base `MoneySysI`.

## DSys / DialSys &mdash; Dialogue

Conversation system. `DialSys.DialogueSysI()` delegates to `DialogueSys_I()`.

## AUDIOSys &mdash; Audio

Sound playback. `AudioSys.AudioSysI()` delegates to `AudiosSys_I()`.

## TABSys &mdash; Tabs / PkPhone

Drives the in-game phone UI. `TABSys.TABSysI()` calls
`TABSys_PkPhoneAppsI()` to bring up the phone's apps.

## TCMSys &mdash; Tab Change Manager

Manages switching between tabs/views. `TCMSysI()` runs `LNG()` and `LSG()`.

## UTPSys &mdash; Unity Teleporter

Handles teleportation between locations (houses for the player and NPCs).
`UnityTeleporterSys.UTPSysI()` forwards to `UHTeleporterSys.UHTPSysI()`. Leaf
classes include `TeleportSystem` (with a `Waypoint` struct) and per-family
teleporters such as `UHTPSys_Player_FamilyTeleporter` and the NPC variants
(`Z_Family`, `Ve_Family`, &hellip;).

## HDSys &mdash; Holiday

Holiday/seasonal logic. `HDSys.HDSysI()` delegates to `HDSys_I()`.

## ITEMSSys &mdash; Items

Item database. The facade `ITEMSys` derives from `ITEMSDatabaseSys`
(namespace `USystemsSys`).

## LOVESys &mdash; Love / relationships

Relationship mechanics. The facade `LOVERSys.LoveSysI()` calls a protected
`LoveSys()` that runs the system (`Run()`).

## ATSys &mdash; Animated Textures

Animated-texture playback. `ATSys.ATSysI()` delegates to
`AnimatedTextureSysI()` in the base `ATSys_AnimatedTextureSysI`.

## SBSys &mdash; Skybox

Skybox control. `SBSys` derives from `SkyBoxSysI`; `SBSysI()` is the entry point.

## FSSys &mdash; Fail-Safe (standalone)

Aggregates `VoiceActorsFailSafetySys` and `AnimatorFailSafetySys` to recover from
missing/failed animations and voice acting. It is a `MonoBehaviour` initialised
on its own rather than from `USys.LoadUSys()`. Its leaf folders mirror the
per-creature structure used by `AIRSys` (e.g. movement / converter animations
under `umbreon/`, `sylveon/`, `vaporeon/`, &hellip;).
