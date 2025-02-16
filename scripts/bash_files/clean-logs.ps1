$ErrorActionPreference = "SilentlyContinue"

# Remove problematic log files and directories
Remove-Item -Path "backend/E:/ASafariM/Logs" -Recurse -Force
Remove-Item -Path "logs" -Recurse -Force
Remove-Item -Path "Logs" -Recurse -Force
Remove-Item -Path "*.log" -Recurse -Force
Remove-Item -Path "log-*.txt" -Recurse -Force

# Clean git
git config core.protectNTFS false
git gc --prune=now
git fsck --full
