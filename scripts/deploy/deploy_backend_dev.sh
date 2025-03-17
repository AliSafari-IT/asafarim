#!/bin/bash

# Set Variables
SERVER_IP="141.136.42.239"
LOCAL_BACKEND_DIR="D:/repos/ASafariM/ASafariM.Api/bin/Release/net9.0"
REMOTE_BACKEND_DIR="/var/www/asafarim/backend"
REMOTE_BACKUP_DIR="/var/www/asafarim/backups"
SERVICE_NAME="asafarim-api"
TIMESTAMP=$(date +%Y%m%d_%H%M%S)
REMOTE_HEALTH_CHECK_URL="https://asafarim.com/api/health"

# Logging function
log() {
    local level=$1
    local message=$2
    local timestamp=$(date +"%Y-%m-%d %H:%M:%S")
    echo "${timestamp} [${level}] ${message}"
}

log "INFO" "🚀 Starting Backend Deployment..."

# Step 1: Stop the running backend service
log "INFO" "🛑 Stopping backend service ($SERVICE_NAME)..."
ssh root@$SERVER_IP "sudo systemctl stop $SERVICE_NAME" || { log "ERROR" "❌ Failed to stop service"; exit 1; }

# Step 2: Create a backup of the current backend
log "INFO" "📦 Creating backup of the current deployment..."
ssh root@$SERVER_IP "mkdir -p $REMOTE_BACKUP_DIR && cp -r $REMOTE_BACKEND_DIR $REMOTE_BACKUP_DIR/backend_$TIMESTAMP"

# Step 3: Build the backend on the local machine
log "INFO" "⚙️ Building backend on local machine..."
cd "$(cygpath -u "D:/repos/ASafariM/ASafariM.Api")" || { log "ERROR" "❌ Local backend directory not found!"; exit 1; }
dotnet clean && dotnet restore && dotnet build -c Release || { log "ERROR" "❌ Build failed!"; exit 1; }

# Step 4: Ensure the remote backend directory exists
log "INFO" "📂 Ensuring remote backend directory exists..."
ssh root@$SERVER_IP "mkdir -p $REMOTE_BACKEND_DIR && sudo chown -R www-data:www-data $REMOTE_BACKEND_DIR && sudo chmod -R 755 $REMOTE_BACKEND_DIR "

# Step 5: Copy the new build to the server
log "INFO" "🚛 Deploying new backend files to the server..."
scp -r "$LOCAL_BACKEND_DIR"/* root@$SERVER_IP:$REMOTE_BACKEND_DIR || { log "ERROR" "❌ Failed to copy files!"; exit 1; }

# Step 6: Set correct permissions on the server
log "INFO" "🔑 Setting correct file permissions..."
ssh root@$SERVER_IP "sudo chown -R www-data:www-data $REMOTE_BACKEND_DIR && sudo chmod -R 755 $REMOTE_BACKEND_DIR"

# Step 7: Restart the backend service
log "INFO" "🔄 Restarting backend service ($SERVICE_NAME)..."
ssh root@$SERVER_IP "sudo systemctl restart $SERVICE_NAME" || { log "ERROR" "❌ Failed to restart service!"; exit 1; }

# Step 8: Check API health status
log "INFO" "🌍 Checking API health..."
HEALTH_RESPONSE=$(ssh root@$SERVER_IP "sudo systemctl daemon-reload && sudo systemctl restart $SERVICE_NAME && sudo systemctl status $SERVICE_NAME && curl -s $REMOTE_HEALTH_CHECK_URL")

if echo "$HEALTH_RESPONSE" | grep -q '"status":"healthy"'; then
    log "INFO" "✅ Backend is running successfully!"
else
    log "ERROR" "❌ Backend health check failed! Rolling back..."
   #  ssh root@$SERVER_IP "rm -rf $REMOTE_BACKEND_DIR && cp -r $REMOTE_BACKUP_DIR/backend_$TIMESTAMP $REMOTE_BACKEND_DIR && sudo systemctl restart $SERVICE_NAME"
    exit 1
fi
log "INFO" "✅ Deployment completed successfully!"