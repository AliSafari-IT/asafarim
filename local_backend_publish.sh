SERVER_IP="141.136.42.239"
REMOTE_DEPLOY_DIR="/var/www/asafarim/backend"
REMOTE_BACKUP_DIR="/var/www/asafarim/backups"
TIMESTAMP=$(date +%Y%m%d%H%M%S)
LOCAL_BACKEND_DIR="D:/repos/ASafariM/ASafariM.Api"

cd "$LOCAL_BACKEND_DIR" || { echo "❌ Error: Directory not found - $LOCAL_BACKEND_DIR"; exit 1; }
echo "current directory: $(pwd)"

# Create deploy directory if not exists on the remote server
echo "📁 Ensuring deployment directory exists..."
ssh "$SERVER_IP" "mkdir -p $REMOTE_DEPLOY_DIR && sudo chown -R www-data:www-data $REMOTE_DEPLOY_DIR" || { echo "❌ Error: Failed to create deploy directory!"; exit 1; }

# Check if deploy directory exists
echo "📁 Checking deploy directory..."
ssh "$SERVER_IP" "test -d $REMOTE_DEPLOY_DIR" || { echo "❌ Error: Deploy directory not found on remote server - $REMOTE_DEPLOY_DIR"; exit 1; }

# Create a backup of the current deployment
echo "📦 Creating backup..."
ssh "$SERVER_IP" "mkdir -p $REMOTE_BACKUP_DIR && cp -r $REMOTE_DEPLOY_DIR/* $REMOTE_BACKUP_DIR/backend_$TIMESTAMP" || { echo "❌ Error: Failed to create backup!"; exit 1; }

# Build and publish backend
echo "🚀 Building and publishing backend..."
ssh "$SERVER_IP" "cd $REMOTE_DEPLOY_DIR && dotnet publish -c Release -o $REMOTE_DEPLOY_DIR" || { echo "❌ Error: Failed to build and publish backend!"; exit 1; }

echo "🎉 Deployment successful!"