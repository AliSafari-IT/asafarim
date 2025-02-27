# Set Variables
FRONTEND_DIR="/var/www/asafarim/ASafariM.Clients/asafarim-ui"
BACKEND_DIR="/var/www/asafarim/ASafariM.Api"
BASE_DIR="/var/www/asafarim"
SERVER_IP="141.136.42.239"
REMOTE_DEPLOY_DIR="/var/www/asafarim.com/public_html"
REMOTE_BACKUP_DIR="/var/www/asafarim/backups"
SERVICE_NAME="asafarim-api"
HEALTH_CHECK_URL="https://asafarim.com/api/health"
TIMESTAMP=$(date +"%Y-%m-%d_%H-%M-%S")

# Functions
# Logging function
log () {
    local level=$1
    local message=$2
    local timestamp=$(date +"%Y-%m-%d_%H-%M-%S")
    echo "[$timestamp] [$level] $message"
}
# Function to check if a git pull is needed
update_repo() {
    local dir=$1
    cd "$dir" || { log "ERROR" "❌ Local directory not found!"; exit 1; }
        # Check if there are updates on remote
    echo "🔄 Checking for updates in $1..."
    CURRENT_BRANCH=$(git rev-parse --abbrev-ref HEAD)
    git fetch origin "$CURRENT_BRANCH"

    LOCAL_COMMIT=$(git rev-parse HEAD)
    REMOTE_COMMIT=$(git rev-parse "origin/$CURRENT_BRANCH")

    if [ "$LOCAL_COMMIT" != "$REMOTE_COMMIT" ]; then
        echo "📥 Updates found! Pulling latest changes..."
        git pull origin "$CURRENT_BRANCH" || { echo "❌ Error: Git pull failed!"; exit 1; }
    else
        echo "✅ No updates needed."
    fi
}

# **********************************************************
log "INFO" "🔍 Checking if a git pull is needed..."
update_repo "$BASE_DIR"

# Ensure the deployment directory exists
log "INFO" "📂 Ensuring the deployment directory exists..."
ssh root@$SERVER_IP "mkdir -p $REMOTE_DEPLOY_DIR"
# Create a backup of the current deployment

log "INFO" "📦 Creating backup of the current deployment..."
ssh root@$SERVER_IP "mkdir -p $REMOTE_BACKUP_DIR && cp -r $REMOTE_DEPLOY_DIR $REMOTE_BACKUP_DIR/deploy_$TIMESTAMP"

# Deploy the frontend using the script in publish_frontend.sh
log "INFO" "🚀 Starting Frontend Deployment..."
bash scripts/deploy/publish_frontend.sh

# Deploy the backend using the script in deploy_backend.sh
log "INFO" "🚀 Starting Backend Deployment..."
bash scripts/deploy/deploy_backend.sh

log "INFO" "✅ Deployment completed successfully!"