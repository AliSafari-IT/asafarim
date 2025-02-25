@echo off

REM Check if ASafariM.Api.exe is running
tasklist /FI "IMAGENAME eq ASafariM.Api.exe" 2>NUL | find /I "ASafariM.Api.exe" >NUL
if "%ERRORLEVEL%"=="0" (
    echo "Killing ASafariM.Api.exe process..."
    taskkill /F /IM ASafariM.Api.exe
) else (
    echo "Process ASafariM.Api.exe not found."
)

cd ..
dotnet watch run --project ASafariM.Api/ASafariM.Api.csproj