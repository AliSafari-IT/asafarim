#!/bin/bash

# Windows-compatible process check
if tasklist /FI "IMAGENAME eq ASafariM.Api.exe" 2> /dev/null | grep -i "ASafariM.Api.exe" > /dev/null; then
    # Kill the process if found
    echo "Killing ASafariM.Api.exe process..."
    taskkill /F /IM ASafariM.Api.exe
else
    echo "Process ASafariM.Api.exe not found."
fi

# Change directory and run the application
cd ..
dotnet watch run --project ASafariM/ASafariM.Api/ASafariM.Api.csproj