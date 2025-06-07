# Ensure the script runs from the project root
$scriptDir = Split-Path -Parent $MyInvocation.MyCommand.Path
$projectRoot = (Get-Item "$scriptDir\..\..\").FullName
Set-Location $projectRoot

Write-Host "Starting ASafariM test process..." -ForegroundColor Cyan

# Variables
$testResultsDir = "$projectRoot\ASafariM.Test\TestResults"

# Create test results directory if it doesn't exist
if (-not (Test-Path $testResultsDir)) {
    New-Item -ItemType Directory -Path $testResultsDir | Out-Null
}

# Get timestamped test results filename
$testResultsFile = & "$scriptDir\Manage-TestResults.ps1" -Action "get-filename"
Write-Host "Test results will be saved to: $testResultsFile" -ForegroundColor Cyan

# Run backend tests
Write-Host "Running backend tests..." -ForegroundColor Cyan
dotnet test "$projectRoot\ASafariM.Test\ASafariM.Test.csproj" --logger "trx;LogFileName=$testResultsFile"
$backendTestResult = $LASTEXITCODE

# Clean up old test results
& "$scriptDir\Manage-TestResults.ps1" -Action "cleanup"

# Check if backend tests passed
if ($backendTestResult -eq 0) {
    Write-Host "✅ Backend tests passed successfully!" -ForegroundColor Green
}
else {
    Write-Host "❌ Backend tests failed with exit code $backendTestResult" -ForegroundColor Red
    Write-Host "See test results at: $testResultsFile" -ForegroundColor Yellow
    exit $backendTestResult
}

# Optional: Run frontend tests if they exist
# Uncomment the following lines if you want to run frontend tests

<#
Write-Host "Running UI tests..." -ForegroundColor Cyan
Set-Location "$projectRoot\ASafariM.Clients\asafarim-ui"
yarn test
$uiTestResult = $LASTEXITCODE

if ($uiTestResult -eq 0) {
    Write-Host "✅ UI tests passed successfully!" -ForegroundColor Green
}
else {
    Write-Host "❌ UI tests failed with exit code $uiTestResult" -ForegroundColor Red
    exit $uiTestResult
}
#>

Write-Host "All tests completed successfully!" -ForegroundColor Green
exit 0
