# Building the docs

This documentation site is produced with [DocFX](https://dotnet.github.io/docfx/).
It combines two sources:

- the **articles** under `docs/articles/` (hand-written Markdown), and
- the **API reference**, generated from the C# in the `PKDSIM/UnityAssets`
  submodule.

## Prerequisites

- **.NET SDK** (8.0 or newer).
- **DocFX** as a global tool:

  ```bash
  dotnet tool install -g docfx
  ```

- The **`PKDSIM/UnityAssets` submodule** must be checked out, because the API
  reference is generated from its source:

  ```bash
  git submodule update --init --depth 1 PKDSIM/UnityAssets
  ```

## One-shot build

From the repository root:

```bash
make docs        # Linux/macOS, or Windows with GNU make installed
```

or, on Windows without `make`:

```powershell
./build.ps1
```

Both commands:

1. ensure the submodule is checked out,
2. install DocFX if it is missing, and
3. run `docfx docs/docfx.json` to produce the static site in `docs/_site/`.

## Manual build

If you prefer to drive DocFX directly:

```bash
# from repo root
git submodule update --init --depth 1 PKDSIM/UnityAssets
docfx metadata docs/docfx.json   # generate api/*.yml from the submodule source
docfx build    docs/docfx.json   # render the static site to docs/_site
```

## Preview locally

```bash
docfx docs/docfx.json --serve
# then open http://localhost:8080
```

## How the build is configured

Everything is driven by `docs/docfx.json`:

- **`metadata.src`** points at `../PKDSIM/UnityAssets/PKDSIM/Assets` and globs
  `**/*.cs`, excluding `Library`, `Samples`, `Plugins`, `TutorialInfo` and the
  imported `Fantasy Skybox` art pack.
- **`allowCompilationErrors: true`** is required: the source is compiled as loose
  `.cs` files without the Unity-generated `.csproj`, so engine types such as
  `MonoBehaviour` are unresolved. DocFX still extracts the public API surface and
  simply emits warnings for the unresolved references.
- **`docs/filterConfig.yml`** restricts the API reference to the
  `project_pkdsim.*` namespaces so third-party symbols don't leak in.

## Generated output (not committed)

The following are build artifacts and are git-ignored (see `docs/.gitignore`):

- `docs/api/` &mdash; generated API YAML + `.manifest`.
- `docs/_site/` &mdash; the rendered static website.
- `docs/obj/` &mdash; DocFX intermediate files.

## Continuous integration

A ready-to-use GitHub Actions workflow is provided at
[`docs/ci/docs.yml.sample`](../ci/docs.yml.sample). Copy it to
`.github/workflows/docs.yml` to enable it:

```bash
mkdir -p .github/workflows
cp docs/ci/docs.yml.sample .github/workflows/docs.yml
```

> [!NOTE]
> It ships as a `.sample` because adding workflow files requires the `workflow`
> OAuth scope, which the automation that created this docs setup did not have.
> Committing it is a one-line manual step for a maintainer.

Once enabled, it builds the site on every push/PR that touches the docs or the
submodule pointer, and (on `main`) publishes `docs/_site` to GitHub Pages
(enable **Settings → Pages → Source: GitHub Actions** first).
