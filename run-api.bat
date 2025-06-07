@echo on
cd /d "%~dp0"

echo [1/5] Terminating existing API processes...
Taskkill /IM "ASafariM.Api.exe" /F > nul 2>&1
Taskkill /IM "dotnet.exe" /F > nul 2>&1
Timeout /t 3 /nobreak > nul

echo [2/5] Cleaning solution...
dotnet clean ASafariM.Api

echo [3/5] Restoring dependencies...
dotnet restore ASafariM.Api

echo [4/5] Building solution...
dotnet build ASafariM.Api --verbosity minimal --no-restore

echo [5/5] Starting API...
cd ASafariM.Api
start "ASafariM API" yarn run start