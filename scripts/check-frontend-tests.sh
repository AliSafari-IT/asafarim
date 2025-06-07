#!/bin/bash

# Set Variables
LOG_DIR="/var/www/asafarim/Logs"
TIMESTAMP=$(date +%Y%m%d_%H%M%S)
DEPLOY_LOG="$LOG_DIR/frontend_tests_$(date +%Y%m%d_%H%M%S).log"

# Ensure log directory exists
mkdir -p "$LOG_DIR"

# Log function
log() {
  echo "$(date +"%Y-%m-%d %H:%M:%S") - $1" | tee -a "$DEPLOY_LOG"
}

log "Starting frontend tests verification..."

# Run all frontend tests
log "Running all frontend tests..."
yarn test

# Check the exit code
if [ $? -ne 0 ]; then
  log "❌ Frontend tests failed. Aborting deployment."
  exit 1
else
  log "✅ All frontend tests passed. Proceeding with deployment."
  exit 0
fi
