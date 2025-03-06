#!/bin/bash

# Set Variables
BASE_DIR="/var/www/asafarim"
FRONTEND_DIR="$BASE_DIR/ASafariM.Clients/asafarim-ui"
DEPLOY_DIR="$BASE_DIR/public_html"
BACKUP_DIR="$BASE_DIR/backups"
TIMESTAMP=$(date +%Y%m%d_%H%M%S)
MAX_RETRIES=5
HEALTH_CHECK_URL="https://asafarim.com/api/health"

echo "🚀 Starting Frontend Deployment..."

# Step 1: Navigate to frontend project
cd "$FRONTEND_DIR" || { echo "❌ Error: Frontend directory not found!"; exit 1; }

# Step 2: Build the frontend
echo "⚙️ Building frontend..."
yarn build || { echo "❌ Error: Build failed!"; exit 1; }

# Step 3: Ensure Deployment Directory Exists
echo "📁 Ensuring deployment directory exists..."
mkdir -p "$DEPLOY_DIR"

# Step 4: Clear old files
echo "🧹 Cleaning old deployment files..."
rm -rf "$DEPLOY_DIR"/*

# Step 5: Move new build files
echo "🚛 Deploying new build files..."
mv dist/* "$DEPLOY_DIR"/ || { echo "❌ Error: Moving files failed!"; exit 1; }

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
