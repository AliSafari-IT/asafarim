# Set Variables
SERVER_IP="141.136.42.239"
LOCAL_FRONTEND_DIR="D:/repos/ASafariM/ASafariM.Clients/asafarim-ui/dist"
REMOTE_DEPLOY_DIR="/var/www/asafarim.com/public_html"

# Logging function
log() {
    local level=$1
    local message=$2
    local timestamp=$(date +"%Y-%m-%d %H:%M:%S")
    echo "${timestamp} [${level}] ${message}"
}


# Ensure the deployment directory exists
log "INFO" "📂 Ensuring the deployment directory exists..."
ssh root@$SERVER_IP "mkdir -p $REMOTE_DEPLOY_DIR"

# Clean up old deployment
log "INFO" "🧹 Cleaning up old deployment..."
ssh root@$SERVER_IP "rm -rf $REMOTE_DEPLOY_DIR/*"

# Copy the frontend build files (not the dist folder itself)
log "INFO" "🚀 Copying frontend build files..."
scp -r $LOCAL_FRONTEND_DIR/* root@$SERVER_IP:$REMOTE_DEPLOY_DIR

# Set correct permissions
log "INFO" "🔑 Setting correct file permissions..."
ssh root@$SERVER_IP "chown -R www-data:www-data $REMOTE_DEPLOY_DIR && chmod -R 755 $REMOTE_DEPLOY_DIR"

# Restart Nginx
log "INFO" "🔄 Restarting Nginx..."
ssh root@$SERVER_IP "systemctl restart nginx"

# Check if the deployment was successful
if [ $? -eq 0 ]; then
    log "INFO" "✅ Deployment completed successfully!"
    log "INFO" "🌍 Visit https://asafarim.com to check the frontend."
else
    log "ERROR" "❌ Deployment failed!"
fi