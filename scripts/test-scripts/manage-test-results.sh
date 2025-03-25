#!/bin/bash

# Configuration
TEST_RESULTS_DIR="../../ASafariM.Test/TestResults"
MAX_FILES_TO_KEEP=5

# Function to create a timestamped test results file
create_timestamped_results_file() {
    local timestamp=$(date +"%Y%m%d%H%M%S")
    echo "${TEST_RESULTS_DIR}/test_results_${timestamp}.trx"
}

# Function to clean up old test result files
cleanup_old_results() {
    # Count how many .trx files we have
    local file_count=$(find "${TEST_RESULTS_DIR}" -maxdepth 1 -name "test_results_*.trx" | wc -l)
    
    # If we have more than MAX_FILES_TO_KEEP, delete the oldest ones
    if [ "$file_count" -gt "$MAX_FILES_TO_KEEP" ]; then
        # Calculate how many files to delete
        local files_to_delete=$((file_count - MAX_FILES_TO_KEEP))
        
        # Find the oldest files and delete them
        find "${TEST_RESULTS_DIR}" -maxdepth 1 -name "test_results_*.trx" -type f -printf "%T@ %p\n" | \
        sort -n | head -n "$files_to_delete" | cut -d' ' -f2- | xargs rm -f
        
        echo "Cleaned up $files_to_delete old test result file(s)"
    fi
    
    # Also clean up old Deploy_User folders older than 7 days
    find "${TEST_RESULTS_DIR}" -maxdepth 1 -name "Deploy_User*" -type d -mtime +7 -exec rm -rf {} \;
}

# Main execution
case "$1" in
    "get-filename")
        create_timestamped_results_file
        ;;
    "cleanup")
        cleanup_old_results
        ;;
    *)
        echo "Usage: $0 {get-filename|cleanup}"
        exit 1
        ;;
esac

exit 0
