#!/bin/bash

# Set Variables
BASE_DIR="/var/www"
REPO_DIR="$BASE_DIR/asafarim"
CLI_DIR="$REPO_DIR/ASafariM.Clients/asafarim-cli"
CLI_DEPLOY_DIR="$BASE_DIR/asafarim-cli"
CLI_SERVICE_NAME="asafarim-cli"
LOG_DIR="$REPO_DIR/logs"
DEPLOY_LOG="$LOG_DIR/deploy_cli_$(date +%Y%m%d_%H%M%S).log"

# Ensure log directory exists
mkdir -p "$LOG_DIR"

# Log function
log() {
  echo "$(date +"%Y-%m-%d %H:%M:%S") - $1" | tee -a "$DEPLOY_LOG"
}

# Error handling function
handle_error() {
  log "ERROR: $1"
  if [ "$2" = "exit" ]; then
    log "Exiting due to critical error"
    exit 1
  fi
}

log "******* Updating ASafariM CLI Server *******"

# Check if server.js file exists in source directory
if [ ! -f "$CLI_DIR/server.js" ]; then
  handle_error "server.js file not found in source directory" "exit"
fi

# Check if server.js file exists in deployment directory
if [ ! -f "$CLI_DEPLOY_DIR/server.js" ]; then
  handle_error "server.js file not found in deployment directory" "exit"
fi

# Check if we have write access to the deployment directory server.js file
if [ ! -w "$CLI_DEPLOY_DIR/server.js" ]; then
  handle_error "No write access to $CLI_DEPLOY_DIR/server.js" "exit"
fi

# Copy only the server.js file to the deployment directory
log "Copying server.js file to deployment directory"
cp "$CLI_DIR/server.js" "$CLI_DEPLOY_DIR/server.js" || handle_error "Failed to copy server.js file" "exit"

log "CLI server.js file updated successfully!"
log "=== UPDATE SUMMARY ==="
log "Updated file: $CLI_DEPLOY_DIR/server.js"
log "Service name: $CLI_SERVICE_NAME"
log "Log file: $DEPLOY_LOG"
log "=== END UPDATE SUMMARY ==="

echo
echo "  CLI server.js file updated successfully!  "
echo
echo "Note: Service restart requires sudo privileges and was not performed."
echo "To restart the service, run: sudo systemctl restart $CLI_SERVICE_NAME"
