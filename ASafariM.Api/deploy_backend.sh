#!/bin/bash

set -e  # Exit on any error

# Set Variables
BACKEND_DIR="/var/www/asafarim/ASafariM.Api"
PUBLISH_DIR="/var/www/asafarim/backend"
BACKUP_DIR="/var/www/asafarim/backups"
TIMESTAMP=$(date +%Y%m%d_%H%M%S)
MAX_RETRIES=3
HEALTH_CHECK_URL="http://localhost:5001/health"

# Clean old backups (keep only the newest one)
cd "$BACKUP_DIR" && ls -t | tail -n +2 | xargs -r rm -rf

# Function to check API health
check_health() {
    local retries=0
    while [ $retries -lt 30 ]; do
        echo "Attempt $((retries + 1)) to check health..."
        response=$(curl -vk "$HEALTH_CHECK_URL" 2>&1)
        echo "Health check response:"
        echo "$response"
        
        if echo "$response" | grep -q '"status":"Healthy"'; then
            return 0
        fi
        
        # Check logs for errors
        echo "Recent application logs:"
        sudo journalctl -u asafarim-api -n 20 --no-pager
        
        sleep 1
        retries=$((retries + 1))
    done
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

echo "🚀 Starting Backend Deployment..."

# Create backup directory
mkdir -p "$BACKUP_DIR"

# Backup current version
if [ -d "$PUBLISH_DIR" ]; then
    echo "📦 Creating backup..."
    mkdir -p "${BACKUP_DIR}/backup_${TIMESTAMP}"
    cp -r "$PUBLISH_DIR"/* "${BACKUP_DIR}/backup_${TIMESTAMP}/"
fi

# Navigate to backend project
cd "$BACKEND_DIR" || { echo "❌ Error: Backend directory not found!"; exit 1; }

# Restore dependencies
echo "📦 Restoring dependencies..."
dotnet restore || { echo "❌ Error: Failed to restore dependencies!"; exit 1; }

# Build the backend
echo "⚙️ Building backend..."
dotnet build --configuration Release || { echo "❌ Error: Build failed!"; exit 1; }

# Run tests (if they exist)
if [ -f "ASafariM.Tests/ASafariM.Tests.csproj" ]; then
    echo "🧪 Running tests..."
    dotnet test || { echo "❌ Tests failed!"; exit 1; }
fi

# Publish the backend
echo "📤 Publishing backend..."
dotnet publish --configuration Release --output "$PUBLISH_DIR" || { echo "❌ Error: Publish failed!"; exit 1; }

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

# Check if service is running
echo "🔍 Checking service status..."
if ! systemctl is-active --quiet asafarim-api; then
    echo "⚠️ Warning: Service not started by systemd, but may still be running"
    echo "📋 Service logs:"
    journalctl -u asafarim-api -n 50 --no-pager
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
