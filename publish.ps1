# PowerShell script for building and publishing ASafariM project
# This script includes test verification before deployment

# Configuration
$ProjectRoot = $PSScriptRoot
$LogDir = Join-Path $ProjectRoot "logs"
$LogFile = Join-Path $LogDir "publish_$(Get-Date -Format 'yyyyMMdd_HHmmss').log"
$TestResultsFile = Join-Path $ProjectRoot "ASafariM.Test\TestResults\test_results.trx"

# Create logs directory if it doesn't exist
if (-not (Test-Path $LogDir)) {
    New-Item -Path $LogDir -ItemType Directory | Out-Null
}

# Function to log messages
function Write-Log {
    param (
        [string]$Message,
        [string]$ForegroundColor = "White"
    )
    
    $timestamp = Get-Date -Format "yyyy-MM-dd HH:mm:ss"
    $logMessage = "[$timestamp] $Message"
    
    # Write to console
    Write-Host $logMessage -ForegroundColor $ForegroundColor
    
    # Write to log file
    Add-Content -Path $LogFile -Value $logMessage
}

# Function to run tests and verify results
function Test-AndVerify {
    Write-Log "Running tests before deployment..." "Cyan"
    
    # Run the tests
    Write-Log "Executing backend tests..."
    dotnet test "$ProjectRoot\ASafariM.Test\ASafariM.Test.csproj" --logger "trx;LogFileName=$TestResultsFile"
    
    if ($LASTEXITCODE -ne 0) {
        Write-Log "❌ Test execution failed with exit code $LASTEXITCODE" "Red"
        return $false
    }
    
    # Verify test results
    Write-Log "Verifying test results..."
    & "$ProjectRoot\scripts\test-scripts\verify-tests.ps1" -TestResultsFile $TestResultsFile
    
    if ($LASTEXITCODE -ne 0) {
        Write-Log "❌ Test verification failed. Deployment aborted." "Red"
        return $false
    }
    
    Write-Log "✅ All tests passed. Proceeding with deployment." "Green"
    return $true
}

# Function to clean old log files (keep last 10)
function Clean-OldLogs {
    $logFiles = Get-ChildItem -Path $LogDir -Filter "publish_*.log" | Sort-Object LastWriteTime -Descending
    
    if ($logFiles.Count -gt 10) {
        Write-Log "Cleaning old log files..."
        $logFiles | Select-Object -Skip 10 | ForEach-Object {
            Remove-Item $_.FullName -Force
            Write-Log "Removed old log file: $($_.Name)"
        }
    }
}

# Function to build and publish the project
function Build-AndPublish {
    # Build API
    Write-Log "Building ASafariM.Api..." "Cyan"
    dotnet publish "$ProjectRoot\ASafariM.Api\ASafariM.Api.csproj" -c Release -o "$ProjectRoot\publish\api"
    
    if ($LASTEXITCODE -ne 0) {
        Write-Log "❌ API build failed with exit code $LASTEXITCODE" "Red"
        return $false
    }
    
    # Build UI
    Write-Log "Building asafarim-ui..." "Cyan"
    Set-Location "$ProjectRoot\ASafariM.Clients\asafarim-ui"
    yarn build
    
    if ($LASTEXITCODE -ne 0) {
        Write-Log "❌ UI build failed with exit code $LASTEXITCODE" "Red"
        Set-Location $ProjectRoot
        return $false
    }
    
    # Copy UI build to publish directory
    Write-Log "Copying UI build to publish directory..."
    New-Item -Path "$ProjectRoot\publish\ui" -ItemType Directory -Force | Out-Null
    Copy-Item -Path "$ProjectRoot\ASafariM.Clients\asafarim-ui\dist\*" -Destination "$ProjectRoot\publish\ui" -Recurse -Force
    
    # Build Blog
    Write-Log "Building asafarim-blog..." "Cyan"
    Set-Location "$ProjectRoot\ASafariM.Clients\asafarim-blog"
    yarn build
    
    if ($LASTEXITCODE -ne 0) {
        Write-Log "❌ Blog build failed with exit code $LASTEXITCODE" "Red"
        Set-Location $ProjectRoot
        return $false
    }
    
    # Copy Blog build to publish directory
    Write-Log "Copying Blog build to publish directory..."
    New-Item -Path "$ProjectRoot\publish\blog" -ItemType Directory -Force | Out-Null
    Copy-Item -Path "$ProjectRoot\ASafariM.Clients\asafarim-blog\build\*" -Destination "$ProjectRoot\publish\blog" -Recurse -Force
    
    # Return to project root
    Set-Location $ProjectRoot
    
    Write-Log "✅ Build and publish completed successfully!" "Green"
    return $true
}

# Main execution
Write-Log "Starting ASafariM publish process..." "Cyan"

# Clean old logs
Clean-OldLogs

# Run tests and verify results
$testsPass = Test-AndVerify
if (-not $testsPass) {
    Write-Log "❌ Deployment aborted due to test failures." "Red"
    exit 1
}

# Build and publish
$publishSuccess = Build-AndPublish
if (-not $publishSuccess) {
    Write-Log "❌ Deployment failed during build process." "Red"
    exit 1
}

Write-Log "✅ ASafariM successfully built and published!" "Green"
Write-Log "Published to: $ProjectRoot\publish" "Green"
exit 0
