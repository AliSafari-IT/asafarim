#!/usr/bin/env pwsh
Set-StrictMode -Version Latest
$ErrorActionPreference = "Stop"

Write-Host ""
Write-Host "=== Adding Migration to Database ===`n"

# Ensure the script runs from the project root
$SCRIPT_DIR = Split-Path -Parent $MyInvocation.MyCommand.Path
$PROJECT_ROOT = Resolve-Path "$SCRIPT_DIR\..\.."
Set-Location $PROJECT_ROOT

# Define paths for the project and startup project
$InfrastructureProject = "ASafariM.Infrastructure"
$StartupProject = "ASafariM.Api"

# Prompt for migration name
$MigrationName = Read-Host "Enter migration name"
if ([string]::IsNullOrWhiteSpace($MigrationName)) {
    Write-Host "Migration name cannot be empty." -ForegroundColor Red
    exit 1
}

Write-Host "`nAdding migration: $MigrationName`n"

# Add migration
dotnet ef migrations add $MigrationName `
    --project $InfrastructureProject `
    --startup-project $StartupProject `
    --verbose

Write-Host "`nMigration $MigrationName added successfully.`n"

# Update database
dotnet ef database update `
    --project $InfrastructureProject `
    --startup-project $StartupProject `
    --verbose

Write-Host "`nDatabase updated successfully.`n"

# Optional: Run the application
$RunApp = Read-Host "Do you want to run the application? (y/n)"
if ($RunApp -match '^[Yy]$') {
    dotnet run --project $StartupProject
}
