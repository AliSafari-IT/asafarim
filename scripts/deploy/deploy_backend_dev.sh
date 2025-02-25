#!/bin/bash

# Set Variables
SERVER_IP="141.136.42.239"
LOCAL_BACKEND_DIR="./ASafariM.Api"
REMOTE_BACKEND_DIR="/var/www/asafarim/backend"
REMOTE_BACKUP_DIR="/var/www/asafarim/backups"
TIMESTAMP=$(date +%Y%m%d_%H%M%S)
HEALTH_CHECK_URL="http://localhost:5000/api/health"
REMOTE_HEALTH_CHECK_URL="https://asafarim.com/api/health"
MAX_RETRIES=20

# Logging function
log() {
    local level=$1
    local message=$2
    local timestamp=$(date +"%Y-%m-%d %H:%M:%S")
    echo "${timestamp} [${level}] ${message}"
}

# Function to check API health
# Modify the health check function
check_health() {
    local url=$1
    local retries=0
    local max_retries=$MAX_RETRIES

    while [ $retries -lt $max_retries ]; do
        log "INFO" "Attempt $((retries + 1)) to check health at $url..."
        response=$(curl -sk "$url" 2>&1)

        if echo "$response" | grep -q '"status":"healthy"'; then
            log "INFO" "✅ Health check passed at $url"
            return 0
        fi

        sleep_time=$((1 + retries / 10))
        log "INFO" "Waiting ${sleep_time} seconds before next attempt..."
        sleep $sleep_time
        retries=$((retries + 1))
    done

    log "ERROR" "❌ Health check failed at $url after $max_retries attempts"
    return 1
}

# Add sequential health checks
# log "INFO" "🏥 Performing local health check..."
# if ! check_health $HEALTH_CHECK_URL; then
#     log "ERROR" "❌ Local health check failed"
#     exit 1
# fi

log "INFO" "🌍 Performing remote health check..."
if ! check_health $REMOTE_HEALTH_CHECK_URL; then
    log "ERROR" "❌ Remote health check failed"
    exit 1
fi

# Function for rollback
rollback() {
    log "WARN" "⚠️ Rolling back deployment..."
    if [ -d "${REMOTE_BACKUP_DIR}/backup_${TIMESTAMP}" ]; then
        rm -rf "$REMOTE_BACKEND_DIR"/*
        cp -r "${REMOTE_BACKUP_DIR}/backup_${TIMESTAMP}"/* "$REMOTE_BACKEND_DIR"/
        ssh root@$SERVER_IP "sudo systemctl restart asafarim-backend"
        if check_health $REMOTE_HEALTH_CHECK_URL; then
            log "INFO" "✅ Rollback successful"
        else
            log "ERROR" "❌ Rollback failed - manual intervention required"
            exit 1
        fi
    else
        log "ERROR" "❌ No backup found for rollback"
        exit 1
    fi
}

# Main deployment process
log "INFO" "🚀 Starting Backend Deployment..."

# Create backup directory
mkdir -p "$REMOTE_BACKUP_DIR"

# Backup current version
if [ -d "$REMOTE_BACKEND_DIR" ]; then
    log "INFO" "📦 Creating backup..."
    mkdir -p "${REMOTE_BACKUP_DIR}/backup_${TIMESTAMP}"
    cp -r "$REMOTE_BACKEND_DIR"/* "${REMOTE_BACKUP_DIR}/backup_${TIMESTAMP}/"
fi

# Windows-specific process cleanup
cleanup_processes() {
    echo "🛑 Stopping any running processes..."
    
    # Kill dotnet processes
    taskkill /F /IM dotnet.exe 2>/dev/null || true
    sleep 2
    
    # Kill processes using build files
    build_dir="./ASafariM.Api/bin"
    if [ -d "$build_dir" ]; then
        echo "Checking for locked files in $build_dir..."
        handle.exe -accepteula -nobanner -a "$build_dir" 2>/dev/null | awk '/pid:/ {print $2}' | xargs -I {} taskkill /F /PID {} 2>/dev/null || true
    fi
    
    echo "✅ Process cleanup completed"
}

# Add cleanup with retries and verification
MAX_RETRIES=3
retries=0
while [ $retries -lt $MAX_RETRIES ]; do
    cleanup_processes
    sleep 2
    
    # Verify no dotnet processes are running
    if ! tasklist /FI "IMAGENAME eq dotnet.exe" 2>/dev/null | grep -q dotnet.exe; then
        echo "✅ No dotnet processes running"
        break
    fi
    
    retries=$((retries + 1))
done

# Add cleanup with retries
MAX_CLEANUP_RETRIES=3
cleanup_retries=0
while [ $cleanup_retries -lt $MAX_CLEANUP_RETRIES ]; do
    cleanup_processes
    sleep 1
    cleanup_retries=$((cleanup_retries + 1))
done

# Build and deploy
log "INFO" "Building and deploying backend..."
yarn api:build
scp -r ./ASafariM.Api/bin/Release/net9.0/* root@$SERVER_IP:$REMOTE_BACKEND_DIR

# Health checks
# log "INFO" "🏥 Performing local health check..."
# if ! check_health $HEALTH_CHECK_URL; then
#     log "ERROR" "❌ Local health check failed"
#     exit 1
# fi

log "INFO" "🌍 Performing remote health check..."
if ! check_health $REMOTE_HEALTH_CHECK_URL; then
    log "ERROR" "❌ Remote health check failed"
    exit 1
fi

log "INFO" "✅ Backend deployment completed successfully!"
log "INFO" "🌍 API is running at $HEALTH_CHECK_URL"
