@echo off
setlocal enabledelayedexpansion

echo.
echo === Updating Database for a Given Migration ===
echo.

:: Ensure the script runs from the project root
set SCRIPT_DIR=%~dp0
cd /d "%SCRIPT_DIR%\..\.." || exit /b 1

:: Define paths for the project and startup project
set INFRASTRUCTURE_PROJECT=ASafariM.Infrastructure
set STARTUP_PROJECT=ASafariM.Api

:: Prompt for migration name
set /p MIGRATION_NAME=Enter migration name (or leave empty for latest): 

:: Update database
if "%MIGRATION_NAME%"=="" (
    echo.
    echo Updating database to the latest migration...
    dotnet ef database update ^
        --project "%INFRASTRUCTURE_PROJECT%" ^
        --startup-project "%STARTUP_PROJECT%" ^
        --verbose
) else (
    echo.
    echo Updating database to migration: %MIGRATION_NAME%
    dotnet ef database update "%MIGRATION_NAME%" ^
        --project "%INFRASTRUCTURE_PROJECT%" ^
        --startup-project "%STARTUP_PROJECT%" ^
        --verbose
)

echo.
echo Database update completed.
echo.
