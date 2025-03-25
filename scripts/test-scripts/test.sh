#!/bin/bash

# Ensure the script runs from the project root
SCRIPT_DIR=$(dirname "$0")
PROJECT_ROOT=$(cd "$SCRIPT_DIR/../../" && pwd)
cd "$PROJECT_ROOT" || exit 1

echo "Starting ASafariM test process..."

# Variables
TEST_RESULTS_DIR="$PROJECT_ROOT/ASafariM.Test/TestResults"
TEST_RESULTS_FILE="$TEST_RESULTS_DIR/test_results.trx"

# Create test results directory if it doesn't exist
mkdir -p "$TEST_RESULTS_DIR"

# Run backend tests
echo "Running backend tests..."
dotnet test "$PROJECT_ROOT/ASafariM.Test/ASafariM.Test.csproj" --logger "trx;LogFileName=$TEST_RESULTS_FILE"
BACKEND_TEST_RESULT=$?

# Check if backend tests passed
if [ $BACKEND_TEST_RESULT -eq 0 ]; then
  echo "✅ Backend tests passed successfully!"
else
  echo "❌ Backend tests failed with exit code $BACKEND_TEST_RESULT"
  echo "See test results at: $TEST_RESULTS_FILE"
  exit $BACKEND_TEST_RESULT
fi

# Optional: Run frontend tests if they exist
# Uncomment the following lines if you want to run frontend tests

# echo "Running UI tests..."
# cd "$PROJECT_ROOT/ASafariM.Clients/asafarim-ui" && yarn test
# UI_TEST_RESULT=$?

# if [ $UI_TEST_RESULT -eq 0 ]; then
#   echo "✅ UI tests passed successfully!"
# else
#   echo "❌ UI tests failed with exit code $UI_TEST_RESULT"
#   exit $UI_TEST_RESULT
# fi

echo "All tests completed successfully!"
exit 0
