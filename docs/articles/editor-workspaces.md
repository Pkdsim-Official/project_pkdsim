# Editor workspaces

Alongside the runtime `USys`, the project ships editor-only tooling under
`PKDSIM/Assets/Editor/`. These scripts only run inside the Unity Editor.

## Project_PkdsimEditor

`project_pkdsim.Assets.Editor.Project_PkdsimEditor` is the editor-side entry
point. On `OnEnable()` it initialises the editor workspaces:

```csharp
private void OnEnable()
{
    EditorWorkspaces.EditorWorkspacesInitializer();
}
```

## EditorWorkspaces

`EditorWorkspaces` (`...Editor.Workspaces`) is the hub that the editor entry
point initialises. Individual workspaces hang off it, mirroring the runtime
"system" pattern but for editor tooling.

## Namespace workspace

Under `Editor/Workspaces/Namespace/` there is tooling for auditing the project's
namespaces:

- **`Namespace`** &mdash; placeholder/host type for the workspace.
- **`NamespaceExporter`** &mdash; an `EditorWindow` exposing a
  `Window ▸ Export Namespaces to CSV` menu item. It walks every `*.cs` file under
  `Application.dataPath`, reads the first `namespace` declaration in each file,
  and writes a `File Name,Namespace` CSV.

  > [!WARNING]
  > `NamespaceExporter` writes to a **hard-coded absolute path**
  > (`C:/Users/pkdsim_offical/project_pkdsim/PS/NamespaceList.csv`). Anyone
  > running it on another machine will need to change that path first.

## AASys workspace

Under `Editor/Workspaces/AASys/` there is Addressable-Assets editor tooling
(`Editor_AAsys` and the `AA_CA` / `AA_CLSA` helpers) used to manage the project's
addressable asset groups from the editor.
