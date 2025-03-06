#!/bin/bash

set -e # Exit on any error

# Set Variables
BASE_DIR="/var/www"
REPO_DIR="$BASE_DIR/asafarim"
BACKEND_DIR="$REPO_DIR/ASafariM.Api"
PUBLISH_DIR="$REPO_DIR/backend"
BACKUP_DIR="$REPO_DIR/backups/backends"
TIMESTAMP=$(date +%Y%m%d_%H%M%S)
MAX_RETRIES=5
HEALTH_CHECK_URL="https://asafarim.com/api/health"

# Clean old backups (keep only the newest one)
sudo mkdir -p "$BACKUP_DIR"
cd "$BACKUP_DIR" && ls -t | tail -n +2 | xargs -r rm -rf

# Function to check API health
check_health() {
    local retries=0
    local max_retries=20 # Increased to 60 seconds
    while [ $retries -lt $max_retries ]; do
        echo "Attempt $((retries + 1)) to check health..."
        response=$(curl -sk "$HEALTH_CHECK_URL" 2>&1)

        if echo "$response" | grep -q '"status":"healthy"'; then
            echo "✅ Health check passed"
            return 0
        fi

        # Only show logs every 5 attempts to reduce noise
        if [ $((retries % 5)) -eq 0 ]; then
            echo "Recent application logs:"
            sudo journalctl -u asafarim-api -n 10 --no-pager
        fi

        # Wait longer between retries as attempts increase
        sleep_time=$((1 + retries / 10))
        echo "Waiting ${sleep_time} seconds before next attempt..."
        sleep $sleep_time
        retries=$((retries + 1))
    done

    echo "❌ Health check failed after $max_retries attempts"
    return 1
}

# Function for rollback
rollback() {
    echo "⚠️ Rolling back deployment..."
    if [ -d "${BACKUP_DIR}/backup_${TIMESTAMP}" ]; then
        rm -rf "$PUBLISH_DIR"/*
        cp -r "${BACKUP_DIR}/backup_${TIMESTAMP}"/* "$PUBLISH_DIR"/
        systemctl restart asafarim-api
        if check_health; then
            echo "✅ Rollback successful"
        else
            echo "❌ Rollback failed - manual intervention required"
            exit 1
        fi
    else
        echo "❌ No backup found for rollback"
        exit 1
    fi
}

# Function to create backup
create_backup() {
    # Create a backup of the current deployment
    echo "Creating backup..."
    BACKUP_FILE="asafarim-backend_backup_$(date +%Y%m%d_%H%M%S).tar.gz"
    sudo tar -czvf "$BACKUP_DIR/$BACKUP_FILE" -C "$PUBLISH_DIR" .
}

# Function to handle publish failure
handle_publish_failure() {
    echo "⚠️ Failed to publish, rolling back..."
    sudo tar -xvf "$BACKUP_DIR/$BACKUP_FILE" -C "$PUBLISH_DIR"
}

echo "⚙️ Building backend..."
cd "$REPO_DIR" || {
    echo "❌ Error: Repository directory not found!"
    exit 1
}

yarn api:build || {
    echo "❌ Error: Build for API in Release mode failed!"
    exit 1
}

echo "🚀 Starting Backend Deployment..."

# Publish the backend
echo "📤 Publishing backend..."
cd "$BACKEND_DIR" || {
    echo "❌ Error: Backend directory not found!"
    exit 1
}
dotnet publish --configuration Release --output "$PUBLISH_DIR" || {
    echo "❌ Error: Publish failed!"
    handle_publish_failure
}

# Set correct permissions
echo "🔑 Setting correct permissions..."
sudo chown -R www-data:www-data "$PUBLISH_DIR"
sudo chmod -R 755 "$PUBLISH_DIR"

# Update systemd service
echo "⚙️ Updating systemd service..."
sudo cp /tmp/asafarim-api.service /etc/systemd/system/
sudo systemctl daemon-reload

# Restart the backend service
echo "🔄 Restarting backend service..."
sudo systemctl restart asafarim-api

# Wait for service to become ready
echo "🔄 Waiting for backend service to become ready..."
MAX_ATTEMPTS=30
ATTEMPT=0
SERVICE_READY=false

while [ $ATTEMPT -lt $MAX_ATTEMPTS ]; do
    if curl -s -o /dev/null -w "%{http_code}" http://localhost:5000/api/health | grep -q 200; then
        SERVICE_READY=true
        break
    fi
    sleep 2
    ATTEMPT=$((ATTEMPT + 1))
done

if [ "$SERVICE_READY" = false ]; then
    echo "⚠️ Error: Service did not become ready within $((MAX_ATTEMPTS * 2)) seconds"
    echo "📋 Service logs:"
    journalctl -u asafarim-api -n 50 --no-pager
    exit 1
fi

# Health check
echo "🏥 Performing health check..."
if ! check_health; then
    echo "❌ Health check failed - attempting rollback"
    rollback
    if ! check_health; then
        echo "❌ Health check still failing after rollback - manual intervention required"
        exit 1
    else
        echo "⚠️ Rollback successful but deployment script had issues"
        exit 0
    fi
fi

echo "✅ Backend deployment completed successfully!"
echo "🌍 API is running at $HEALTH_CHECK_URL"
exit 0
