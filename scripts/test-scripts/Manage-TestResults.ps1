# PowerShell script to manage test results
param(
    [Parameter(Mandatory=$true)]
    [ValidateSet("get-filename", "cleanup")]
    [string]$Action
)

# Configuration
$TestResultsDir = Join-Path -Path $PSScriptRoot -ChildPath "..\..\ASafariM.Test\TestResults"
$MaxFilesToKeep = 5

# Function to create a timestamped test results file
function Get-TimestampedResultsFile {
    $timestamp = Get-Date -Format "yyyyMMddHHmmss"
    return Join-Path -Path $TestResultsDir -ChildPath "test_results_$timestamp.trx"
}

# Function to clean up old test result files
function Remove-OldResults {
    # Ensure the directory exists
    if (-not (Test-Path -Path $TestResultsDir)) {
        New-Item -Path $TestResultsDir -ItemType Directory -Force | Out-Null
        return
    }
    
    # Get all test result files
    $files = Get-ChildItem -Path $TestResultsDir -Filter "test_results_*.trx" | Sort-Object LastWriteTime
    
    # If we have more than MaxFilesToKeep, delete the oldest ones
    if ($files.Count -gt $MaxFilesToKeep) {
        $filesToDelete = $files.Count - $MaxFilesToKeep
        $filesToRemove = $files | Select-Object -First $filesToDelete
        
        foreach ($file in $filesToRemove) {
            Remove-Item -Path $file.FullName -Force
            Write-Host "Removed old test result file: $($file.Name)"
        }
        
        Write-Host "Cleaned up $filesToDelete old test result file(s)"
    }
    
    # Also clean up old Deploy_User folders older than 7 days
    $oldFolders = Get-ChildItem -Path $TestResultsDir -Directory -Filter "Deploy_User*" | 
                  Where-Object { $_.LastWriteTime -lt (Get-Date).AddDays(-7) }
    
    foreach ($folder in $oldFolders) {
        Remove-Item -Path $folder.FullName -Recurse -Force
        Write-Host "Removed old test folder: $($folder.Name)"
    }
}

# Main execution
switch ($Action) {
    "get-filename" {
        Get-TimestampedResultsFile
    }
    "cleanup" {
        Remove-OldResults
    }
}
