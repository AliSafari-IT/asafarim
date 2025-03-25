#!/bin/bash

# Script to verify test results and determine if deployment can proceed
# Default test results file path
TEST_RESULTS_FILE="${1:-$PWD/ASafariM.Test/TestResults/test_results.trx}"

# Function to log with timestamp
log() {
  echo "$(date +"%Y-%m-%d %H:%M:%S") - $1"
}

# Check if the file exists
if [ ! -f "$TEST_RESULTS_FILE" ]; then
  log "❌ Test results file not found at: $TEST_RESULTS_FILE"
  exit 1
fi

# Check for failed tests in the TRX file
TOTAL_TESTS=$(grep -o 'total="[0-9]*"' "$TEST_RESULTS_FILE" | head -1 | sed 's/total="\([0-9]*\)"/\1/')
EXECUTED_TESTS=$(grep -o 'executed="[0-9]*"' "$TEST_RESULTS_FILE" | head -1 | sed 's/executed="\([0-9]*\)"/\1/')
PASSED_TESTS=$(grep -o 'passed="[0-9]*"' "$TEST_RESULTS_FILE" | head -1 | sed 's/passed="\([0-9]*\)"/\1/')
FAILED_TESTS=$(grep -o 'failed="[0-9]*"' "$TEST_RESULTS_FILE" | head -1 | sed 's/failed="\([0-9]*\)"/\1/')

# Display test summary
log "Test Summary:"
log "  Total tests: $TOTAL_TESTS"
log "  Executed: $EXECUTED_TESTS"
log "  Passed: $PASSED_TESTS"
log "  Failed: $FAILED_TESTS"

if [ "$FAILED_TESTS" -gt 0 ]; then
  log "❌ $FAILED_TESTS tests failed. Deployment cannot proceed."
  
  # List failed tests if any
  log "Failed Tests:"
  grep -A 2 'outcome="Failed"' "$TEST_RESULTS_FILE" | grep 'testName=' | sed 's/.*testName="\([^"]*\)".*/  - \1/'
  
  exit 1
else
  log "✅ All tests passed! Deployment can proceed."
  exit 0
fi
