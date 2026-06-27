#!/usr/bin/env pwsh
# Build the PKDSIM documentation site on Windows (or anywhere without GNU make).
#
# Usage:
#   ./build.ps1          # build docs into docs/_site
#   ./build.ps1 -Serve   # build and serve at http://localhost:8080

param(
    [switch]$Serve
)

$ErrorActionPreference = 'Stop'
Set-Location -Path $PSScriptRoot

Write-Host '==> Ensuring PKDSIM/UnityAssets submodule is checked out'
git submodule update --init --depth 1 PKDSIM/UnityAssets

if (-not (Get-Command docfx -ErrorAction SilentlyContinue)) {
    Write-Host '==> Installing DocFX global tool'
    dotnet tool install -g docfx
    $env:PATH = "$env:PATH;$env:USERPROFILE\.dotnet\tools"
}

if ($Serve) {
    Write-Host '==> Building and serving docs (http://localhost:8080)'
    docfx 'docs/docfx.json' --serve
} else {
    Write-Host '==> Building docs'
    docfx 'docs/docfx.json'
    Write-Host '==> Done. Output in docs/_site'
}
