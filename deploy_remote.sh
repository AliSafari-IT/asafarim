#!/bin/bash

# Log function for consistent output
log() {
    local level=$1
    local message=$2
    local timestamp=$(date +"%Y-%m-%d_%H-%M-%S")
    echo "[$timestamp] [$level] $message"
}

# Check if a git pull is needed
log "INFO" "🔍 Checking if a git pull is needed..."
cd /var/www/asafarim
git fetch origin
if [ $(git rev-parse HEAD) != $(git rev-parse @{u}) ]; then
    log "INFO" "🔄 Pulling latest changes..."
    git pull origin main
else
    log "INFO" "✅ No updates needed."
fi

# Ensure the deployment directory exists
log "INFO" "📂 Ensuring the deployment directory exists..."
sudo mkdir -p /var/www/asafarim.com/public_html
sudo mkdir -p /var/www/asafarim/backend

# Create a backup of the current deployment
log "INFO" "📦 Creating backup of the current deployment..."
BACKUP_DIR="/var/www/asafarim/backups"
sudo mkdir -p "$BACKUP_DIR"
BACKUP_FILE="asafarim_backup_$(date +%Y%m%d_%H%M%S).tar.gz"
sudo tar -czvf "$BACKUP_DIR/$BACKUP_FILE" -C /var/www/asafarim .

# Start Frontend Deployment
log "INFO" "🚀 Starting Frontend Deployment..."
./scripts/deploy/publish_frontend.sh

# Start Backend Deployment
log "INFO" "🚀 Starting Backend Deployment..."
./scripts/deploy/publish_backend.sh

log "INFO" "✅ Deployment completed successfully!"