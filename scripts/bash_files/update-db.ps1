#!/usr/bin/env pwsh
Set-StrictMode -Version Latest
$ErrorActionPreference = "Stop"

Write-Host ""
Write-Host "=== Updating Database for a Given Migration ===`n"

# Ensure the script runs from the project root
$SCRIPT_DIR = Split-Path -Parent $MyInvocation.MyCommand.Path
$PROJECT_ROOT = Resolve-Path "$SCRIPT_DIR\..\.."
Set-Location $PROJECT_ROOT

# Define paths for the project and startup project
$InfrastructureProject = "ASafariM.Infrastructure"
$StartupProject = "ASafariM.Api"

# Prompt for migration name
$MigrationName = Read-Host "Enter migration name (or leave empty for latest)"

# Update database
if ([string]::IsNullOrWhiteSpace($MigrationName)) {
    Write-Host "`nUpdating database to the latest migration...`n"
    dotnet ef database update `
        --project $InfrastructureProject `
        --startup-project $StartupProject `
        --verbose
} else {
    Write-Host "`nUpdating database to migration: $MigrationName`n"
    dotnet ef database update $MigrationName `
        --project $InfrastructureProject `
        --startup-project $StartupProject `
        --verbose
}

Write-Host "`nDatabase update completed.`n"
