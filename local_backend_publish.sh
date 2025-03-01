#!/bin/bash

SERVER_IP="141.136.42.239"
SERVER_LOGIN="root"
LOCAL_BACKEND_DIR="D:/repos/ASafariM/ASafariM.Api"
LOCAL_DEPLOY_DIR="D:/repos/ASafariM/ASafariM.Api/deploy"
REMOTE_DEPLOY_DIR="/var/www/asafarim/backend"
REMOTE_BACKUPS_DIR="/var/www/asafarim/backups"
TIMESTAMP=$(date +%Y%m%d%H%M%S)
REMOTE_BACKEND_BACKUP_DIR="$REMOTE_BACKUPS_DIR/backend_$TIMESTAMP"

# check if local dirs exists
cd "$LOCAL_BACKEND_DIR" || {
    echo "❌ Error: Directory not found - $LOCAL_BACKEND_DIR"
    exit 1
}
echo "current directory: $(pwd)"

# remove local deploy directory
echo "📁 if exists, remove local deploy directory..."
# check if exists
if [ -d "$LOCAL_DEPLOY_DIR" ]; then
    rm -rf "$LOCAL_DEPLOY_DIR"
fi
# create new one
mkdir -p "$LOCAL_DEPLOY_DIR" && sudo chown -R www-data:www-data "$LOCAL_DEPLOY_DIR"

# navigate to backend project
cd "$LOCAL_BACKEND_DIR" || {
    echo "❌ Error: Directory not found - $LOCAL_BACKEND_DIR"
    exit 1
}
# Publish to local deploy directory
echo "🚀 Publishing backend locally..."
dotnet publish "$LOCAL_BACKEND_DIR/ASafariM.Api.csproj" --configuration Release --output "$LOCAL_DEPLOY_DIR" || {
    echo "❌ Error: Publish failed!"
    exit 1
}

# Create deploy directory if not exists on the remote server
echo "📁 Ensuring deployment directory exists..."
ssh asafarim "mkdir -p $REMOTE_DEPLOY_DIR && sudo chown -R www-data:www-data $REMOTE_DEPLOY_DIR" || {
    echo "❌ Error: Failed to create deploy directory!"
    exit 1
}

# Create a backup of the current deployment on the remote server & Remove all other backups except the latest one
echo "📦 Creating backend backup..."
ssh asafarim "
    mkdir -p $REMOTE_BACKEND_BACKUP_DIR && 
    chmod -R 755 $REMOTE_BACKEND_BACKUP_DIR && 
    cp -r $REMOTE_DEPLOY_DIR/* $REMOTE_BACKEND_BACKUP_DIR && 
    echo '✅ Backup created successfully!' && 
    # Remove all other backups that start with 'backend_'
    find $REMOTE_BACKEND_BACKUP_DIR -mindepth 1 -type d -name 'backend_*' -exec rm -rf {} +
" || {
    echo "❌ Error: Failed to create backup!"
    exit 1
}

# First stop the service gracefully
echo "Stopping asafarim-api service..."
ssh asafarim "sudo systemctl stop asafarim-api.service" || {
    echo "❌ Error: Failed to stop service!"
    exit 1
}

# Move Published local deploy directory to remote server
echo "📁 Copying published local deploy directory to server..."
if [ ! -d "$LOCAL_DEPLOY_DIR" ]; then
    echo "❌ Error: Local deploy directory not found - $LOCAL_DEPLOY_DIR"
    exit 1
fi
scp -r "$LOCAL_DEPLOY_DIR" "asafarim:$REMOTE_DEPLOY_DIR" || {
    echo "❌ Error: Failed to copy files to remote server!"
    exit 1
}

# Copy locally published backend to remote server
echo "🚀 Building and publishing backend..."
if scp -r "$LOCAL_DEPLOY_DIR" "asafarim:$REMOTE_DEPLOY_DIR"; then
    echo "✅ Backend published successfully!"
    echo "🔄 Restarting asafarim-api service..."
    ssh asafarim "sudo systemctl restart asafarim-api.service" || {
        echo "❌ Error: Failed to restart service!"
        exit 1
    }
    echo "🎉 Deployment successful!"
else
    echo "❌ Error: Failed to build and publish backend!"
    echo "🔃 Restoring previous deployment..."
    # remove deploy directory
    ssh asafarim "rm -rf $REMOTE_DEPLOY_DIR" || {
        echo "❌ Error: Failed to remove deploy directory!"
        exit 1
    }
    # Restore previous deployment
    ssh asafarim "cp -r $REMOTE_BACKEND_BACKUP_DIR/* $REMOTE_DEPLOY_DIR && rm -rf $REMOTE_BACKEND_BACKUP_DIR" || {
        echo "❌ Error: Failed to restore previous deployment!"
        exit 1
    }
    echo "✅ Restore completed successfully!"
fi

echo "🎉 Happy coding!"
