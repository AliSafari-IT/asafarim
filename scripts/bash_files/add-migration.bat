@echo off
setlocal enabledelayedexpansion

echo.
echo === Adding Migration to Database ===
echo.

:: Ensure the script runs from the project root
set SCRIPT_DIR=%~dp0
cd /d "%SCRIPT_DIR%\..\.." || exit /b 1

:: Define paths for the project and startup project
set INFRASTRUCTURE_PROJECT=ASafariM.Infrastructure
set STARTUP_PROJECT=ASafariM.Api

:: Prompt for migration name
set /p MIGRATION_NAME=Enter migration name: 
if "%MIGRATION_NAME%"=="" (
    echo Migration name cannot be empty.
    exit /b 1
)

echo.
echo Adding migration: %MIGRATION_NAME%
echo.

:: Add migration
dotnet ef migrations add "%MIGRATION_NAME%" ^
    --project "%INFRASTRUCTURE_PROJECT%" ^
    --startup-project "%STARTUP_PROJECT%" ^
    --verbose

if errorlevel 1 (
    echo Failed to add migration.
    exit /b 1
)

echo.
echo Migration %MIGRATION_NAME% added successfully.
echo.

:: Update database
dotnet ef database update ^
    --project "%INFRASTRUCTURE_PROJECT%" ^
    --startup-project "%STARTUP_PROJECT%" ^
    --verbose

if errorlevel 1 (
    echo Failed to update the database.
    exit /b 1
)

echo.
echo Database updated successfully.
echo.

:: Optional: Run the application
set /p RUN_APP=Do you want to run the application? (y/n): 
if /i "%RUN_APP%"=="y" (
    dotnet run --project "%STARTUP_PROJECT%"
)
