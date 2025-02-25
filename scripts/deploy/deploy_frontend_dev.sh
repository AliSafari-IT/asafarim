#!/bin/bash

# Set Variables
SERVER_IP="141.136.42.239"
LOCAL_FRONTEND_DIR="../ASafariM/ASafariM.Clients/asafarim-ui"
DEPLOY_DIR="/var/www/asafarim.com/public_html"

# Logging function
log() {
    local level=$1
    local message=$2
    local timestamp=$(date +"%Y-%m-%d %H:%M:%S")
    echo "${timestamp} [${level}] ${message}"
}

log "INFO" "🚀 Starting Frontend Deployment..."

# Step 1: Navigate to frontend project
cd "$LOCAL_FRONTEND_DIR" || { log "ERROR" "❌ Error: Frontend directory not found!"; exit 1; }

# Step 2: Install dependencies
log "INFO" "📦 Installing dependencies..."
yarn cache clean && rm -rf node_modules && rm -rf .yarn/cache && yarn install || { log "ERROR" "❌ Error: Failed to install dependencies!"; exit 1; }

# Step 3: Build the frontend
log "INFO" "⚙️ Building frontend..."
yarn build || { log "ERROR" "❌ Error: Build failed!"; exit 1; }

# Step 4: Ensure Deployment Directory Exists
log "INFO" "📁 Ensuring deployment directory exists..."
ssh root@$SERVER_IP "mkdir -p $DEPLOY_DIR"

# Step 5: Clear old files
log "INFO" "🧹 Cleaning old deployment files..."
ssh root@$SERVER_IP "rm -rf $DEPLOY_DIR/*"

# Step 6: Move new build files
log "INFO" "🚛 Deploying new build files..."
scp -r  ./dist/ root@$SERVER_IP:$DEPLOY_DIR || { log "ERROR" "❌ Error: Moving files failed!"; exit 1; }

# Step 7: Set correct permissions
log "INFO" "🔑 Setting correct file permissions..."
ssh root@$SERVER_IP "chown -R www-data:www-data $DEPLOY_DIR && chmod -R 755 $DEPLOY_DIR"

# Step 8: Restart Nginx
log "INFO" "🔄 Restarting Nginx..."
ssh root@$SERVER_IP "systemctl restart nginx" || { log "ERROR" "❌ Error: Failed to restart Nginx!"; exit 1; }

# Step 1: Update Nginx configuration
ssh root@141.136.42.239 "sed -i 's|/var/www/asafarim.com/public_html|/var/www/asafarim/ASafariM.Clients/asafarim-ui/dist|g' /etc/nginx/sites-available/asafarim.com"

# Step 2: Verify Nginx configuration
ssh root@141.136.42.239 "nginx -t"

# Step 3: Ensure proper permissions
ssh root@141.136.42.239 "chown -R www-data:www-data /var/www/asafarim/ASafariM.Clients/asafarim-ui && chmod -R 755 /var/www/asafarim/ASafariM.Clients/asafarim-ui"

# Step 4: Restart Nginx
ssh root@141.136.42.239 "systemctl restart nginx"
# Step 9: Deployment Complete
log "INFO" "✅ Deployment completed successfully!"
log "INFO" "🌍 Visit https://asafarim.com to check the frontend."