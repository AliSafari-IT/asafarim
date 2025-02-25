#!/bin/bash

# Check if ASafariM.Api.exe is running
if pgrep "ASafariM.Api.exe" > /dev/null; then
    # Kill the process if found
    taskkill /F /IM ASafariM.Api.exe
else
    echo "Process ASafariM.Api.exe not found."
fi

# Change directory and run the application
cd ..
dotnet watch run --project ASafariM.Api/ASafariM.Api.csproj