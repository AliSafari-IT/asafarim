# Script to verify test results and determine if deployment can proceed
param(
    [string]$TestResultsFile = "D:\repos\ASafariM\ASafariM.Test\TestResults\test_results.trx"
)

function Write-ColorOutput {
    param(
        [string]$Message,
        [string]$ForegroundColor = "White"
    )
    
    Write-Host $Message -ForegroundColor $ForegroundColor
}

function Test-TestResults {
    param(
        [string]$ResultsFile
    )

    # Check if the file exists
    if (-not (Test-Path $ResultsFile)) {
        Write-ColorOutput "❌ Test results file not found at: $ResultsFile" "Red"
        return $false
    }

    # Load the XML content
    try {
        [xml]$testResults = Get-Content $ResultsFile
    }
    catch {
        Write-ColorOutput "❌ Error reading test results file: $_" "Red"
        return $false
    }

    # Get test summary
    $summary = $testResults.TestRun.ResultSummary
    $total = [int]$summary.Counters.total
    $executed = [int]$summary.Counters.executed
    $passed = [int]$summary.Counters.passed
    $failed = [int]$summary.Counters.failed

    # Display test summary
    Write-ColorOutput "Test Summary:" "Cyan"
    Write-ColorOutput "  Total tests: $total" "White"
    Write-ColorOutput "  Executed: $executed" "White"
    Write-ColorOutput "  Passed: $passed" "Green"
    
    if ($failed -gt 0) {
        Write-ColorOutput "  Failed: $failed" "Red"
        
        # List failed tests if any
        Write-ColorOutput "`nFailed Tests:" "Red"
        $failedTests = $testResults.TestRun.Results.UnitTestResult | Where-Object { $_.outcome -eq "Failed" }
        foreach ($test in $failedTests) {
            Write-ColorOutput "  - $($test.testName)" "Red"
        }
        
        return $false
    }
    else {
        Write-ColorOutput "  Failed: $failed" "Green"
        Write-ColorOutput "`n✅ All tests passed! Deployment can proceed." "Green"
        return $true
    }
}

# Main execution
$result = Test-TestResults -ResultsFile $TestResultsFile

# Return exit code based on test results
if ($result) {
    exit 0  # Success
}
else {
    exit 1  # Failure
}
