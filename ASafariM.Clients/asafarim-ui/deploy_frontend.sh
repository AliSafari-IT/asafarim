#!/bin/bash

# Set Variables
BASE_DIR="/var/www"
FRONTEND_DIR="$BASE_DIR/asafarim/ASafariM.Clients/asafarim-ui"
DEPLOY_DIR="$BASE_DIR/asafarim.com/public_html"
BACKUP_DIR="$BASE_DIR/asafarim/backups/frontend"
TIMESTAMP=$(date +%Y%m%d_%H%M%S)
BACKUP_FILE="asafarim-frontend_backup_${TIMESTAMP}.tar.gz"
MAX_RETRIES=5
HEALTH_CHECK_URL="https://asafarim.com/api/health"

echo "🚀 Starting Frontend Deployment..."

# Clean old backups (keep only the last newest one)
echo "🧹 Cleaning old frontend tar-zipped backups except the last one..."
sudo mkdir -p "$BACKUP_DIR"
cd "$BACKUP_DIR" && ls -t | tail -n +2 | xargs -r rm -rf

# Create a backup of the current deployment
echo "Creating backup..."
sudo tar -czvf "$BACKUP_DIR/$BACKUP_FILE" -C "$DEPLOY_DIR" .

# Step 1: Navigate to frontend project
cd "$FRONTEND_DIR" || { echo "❌ Error: Frontend directory not found!"; exit 1; }

# Step 2: Build the frontend
echo "⚙️ Building frontend..."
yarn build:npx || { echo "❌ Error: Build failed!"; exit 1; }

# Step 3: Ensure Deployment Directory Exists
echo "📁 Ensuring deployment directory exists..."
mkdir -p "$DEPLOY_DIR"

# Step 4: Clear old files
echo "🧹 Cleaning old deployment files..."
rm -rf "$DEPLOY_DIR"/*

# Function to handle move failure
handle_move_failure() {
    echo "⚠️ Failed to move files, rolling back..."
    sudo tar -xvf "$BACKUP_DIR/$BACKUP_FILE" -C "$DEPLOY_DIR"
}

# Step 5: Move new build files
echo "🚛 Deploying new build files..."
mv dist/* "$DEPLOY_DIR"/ || { 
    echo "❌ Error: Moving files failed!"; 
    handle_move_failure
 }

# Step 6: Set correct permissions
echo "🔑 Setting correct file permissions..."
chown -R www-data:www-data "$DEPLOY_DIR"
chmod -R 755 "$DEPLOY_DIR"

# Step 7: Restart Nginx
echo "🔄 Restarting Nginx..."
systemctl restart nginx || { echo "❌ Error: Failed to restart Nginx!"; exit 1; }

# Step 8: Deployment Complete
echo "✅ Deployment completed successfully!"
echo "🌍 Visit https://asafarim.com to check the frontend."
