#!/bin/bash

<<<<<<< HEAD
SERVER_IP="141.136.42.239"
=======
SERVER_IP="141.136.42.239" 
>>>>>>> 13455c2 (chore(deployment): add deployment scripts for backend and frontend)
SERVER_LOGIN="root"
LOCAL_FRONTEND_DIR="D:/repos/ASafariM/ASafariM.Clients/asafarim-ui"
LOCAL_DEPLOY_DIR="D:/repos/ASafariM/ASafariM.Clients/asafarim-ui/dist"
REMOTE_DEPLOY_DIR="/var/www/asafarim.com/public_html"
REMOTE_BACKUPS_DIR="/var/www/asafarim/backups"
TIMESTAMP=$(date +%Y%m%d%H%M%S)
REMOTE_FRONTEND_BACKUP_DIR="$REMOTE_BACKUPS_DIR/frontend_$TIMESTAMP"

# Step 1: Navigate to frontend project
cd "$LOCAL_FRONTEND_DIR" || {
    echo "❌ Error: Directory not found - $LOCAL_FRONTEND_DIR"
    exit 1
}
echo "current directory: $(pwd)"

# check if local dirs exists
if [ ! -d "$LOCAL_FRONTEND_DIR" ]; then
    echo "❌ Error: Directory not found - $LOCAL_FRONTEND_DIR"
    exit 1
fi
echo "current directory: $(pwd)"

# remove local deploy directory
echo "📁 if exists, remove local deploy directory..."
# check if exists
if [ -d "$LOCAL_DEPLOY_DIR" ]; then
    rm -rf "$LOCAL_DEPLOY_DIR"
fi
# create new one
mkdir -p "$LOCAL_DEPLOY_DIR" && sudo chown -R www-data:www-data "$LOCAL_DEPLOY_DIR"

# navigate to frontend project
cd "$LOCAL_FRONTEND_DIR" || {
    echo "❌ Error: Directory not found - $LOCAL_FRONTEND_DIR"
    exit 1
}

# make a clean build
echo "🚀 Building frontend..."
yarn build || {
    echo "❌ Error: Build failed!"
    exit 1
}

# Create deploy directory if not exists on the remote server
echo "📁 Ensuring deployment directory exists..."
ssh asafarim "mkdir -p $REMOTE_DEPLOY_DIR && sudo chown -R www-data:www-data $REMOTE_DEPLOY_DIR" || {
    echo "❌ Error: Failed to create deploy directory!"
    exit 1
}

# Create a backup of the current deployment
echo "📦 Creating backup..."
ssh asafarim "mkdir -p $REMOTE_FRONTEND_BACKUP_DIR && chmod -R 755 $REMOTE_FRONTEND_BACKUP_DIR && cp -r $REMOTE_DEPLOY_DIR/* $REMOTE_FRONTEND_BACKUP_DIR" || {
    echo "❌ Error: Failed to create backup!"
    exit 1
}

# Copying local deploy directory to server
echo "📁 Copying local deploy directory to server..."
scp -r "$LOCAL_DEPLOY_DIR/." "asafarim:$REMOTE_DEPLOY_DIR" || {
    echo "❌ Error: Failed to copy local deploy directory to server!"
    if [ ! -d "$LOCAL_DEPLOY_DIR" ]; then
        echo "❌ Error: Local deploy directory not found - $LOCAL_DEPLOY_DIR"
    fi
    # Restore previous deployment
    echo "🔃 Restoring previous deployment..."
    ssh asafarim "cp -r $REMOTE_FRONTEND_BACKUP_DIR/* $REMOTE_DEPLOY_DIR && rm -rf $REMOTE_FRONTEND_BACKUP_DIR" || {
        echo "❌ Error: Failed to restore previous deployment!"
        exit 1
    }
    echo "✅ Restore completed successfully!"
    exit 1
}

# Restart Nginx
echo "🔄 Restarting Nginx..."
ssh asafarim 'systemctl restart nginx' || {
    echo "❌ Error: Failed to restart Nginx!"
    exit 1
}

# Deployment Complete
echo "✅ Deployment completed successfully!"
echo "🌍 Visit https://asafarim.com to check the frontend."