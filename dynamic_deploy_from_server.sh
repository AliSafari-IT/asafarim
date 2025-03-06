#!/bin/bash

# Set Variables
BASE_DIR="/var/www"
REPO_DIR="$BASE_DIR/asafarim"
FRONTEND_DIR="$REPO_DIR/ASafariM.Clients/asafarim-ui"
BACKEND_DIR="$REPO_DIR/ASafariM.Api"
FRONTEND_DEPLOY_DIR="$BASE_DIR/asafarim.com/public_html"
FRONTEND_BACKUP_DIR="$REPO_DIR/backups/frontend"
BACKEND_DEPLOY_DIR="$REPO_DIR/ASafariM.Api"
BACKEND_BACKUP_DIR="$REPO_DIR/backups/backends"
TIMESTAMP=$(date +%Y%m%d_%H%M%S)
FRONTEND_BACKUP_FILE="asafarim-frontend_backup_${TIMESTAMP}.tar.gz"
BACKEND_BACKUP_FILE="asafarim-backend_backup_${TIMESTAMP}.tar.gz"
SERVICE_NAME="asafarim-api"
SERVICE_FILE="/tmp/$SERVICE_NAME.service"
MAX_RETRIES=5
HEALTH_CHECK_URL="https://asafarim.com/api/health"
LOG_DIR="/var/log/asafarim"

# Function to check if a git pull is needed
update_repo() {
    cd "$1" || { echo "❌ Error: Directory not found - $1"; exit 1; }
    
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

# Function to check for running processes using files
check_processes() {
    cd "$1" || { echo "❌ Error: Directory not found - $1"; exit 1; }
    echo "🔍 Checking for running processes in $1..."

    # Get the total number of files
    total_files=$(git ls-files | wc -l)
    processed_files=0
    last_percent=0

    echo -n "Progress: [ 0"
    
    for file in $(git ls-files); do
        if [ -f "$file" ]; then
            processed_files=$((processed_files + 1))
            percent=$((processed_files * 100 / total_files))
            
            # Check if the file is in use
            if [ $(lsof -t "$file" | wc -l) -gt 0 ]; then
                kill $(lsof -t "$file")
            fi
            
            # Update the progress bar
            if (( percent % 10 == 0 && percent != last_percent )); then
                echo -n "•"
                echo -n ">$percent%"
                last_percent=$percent
            fi
        fi
    done
    
    echo "] 100% Completed"
    echo "✅ Completed checking for running processes in $1."
}

# Step 1: Check for updates in asafarim repository
update_repo "$BASE_DIR"

# Step 2: Check for running processes using files
# check_processes "$FRONTEND_DIR"
 check_processes "$BACKEND_DIR"

# *********************************************************************
# Step 3: Deploy frontend
echo "🚀 Deploying Frontend..."
cd "$FRONTEND_DIR"

echo "🚀 Starting Frontend Deployment..."

# Clean old backups (keep only the last newest one)
echo "🧹 Cleaning old frontend tar-zipped backups except the last one..."
sudo mkdir -p "$FRONTEND_BACKUP_DIR"
cd "$FRONTEND_BACKUP_DIR" && ls -t | tail -n +2 | xargs -r rm -rf

# Create a backup of the current deployment
echo "Creating backup..."
sudo tar -czvf "$FRONTEND_BACKUP_DIR/$FRONTEND_BACKUP_FILE" -C "$FRONTEND_DEPLOY_DIR" .

# Step 1: Navigate to frontend project
cd "$FRONTEND_DIR" || { echo "❌ Error: Frontend directory not found!"; exit 1; }

# Step 2: Build the frontend
echo "⚙️ Building frontend..."
yarn build:npx || { echo "❌ Error: Build failed!"; exit 1; }

# Step 3: Ensure Deployment Directory Exists
echo "📁 Ensuring deployment directory exists..."
mkdir -p "$FRONTEND_DEPLOY_DIR"

# Step 4: Clear old files
echo "🧹 Cleaning old deployment files..."
rm -rf "$FRONTEND_DEPLOY_DIR"/*

# Function to handle move failure
handle_move_failure() {
    echo "⚠️ Failed to move files, rolling back..."
    sudo tar -xvf "$FRONTEND_BACKUP_DIR/$FRONTEND_BACKUP_FILE" -C "$FRONTEND_DEPLOY_DIR"
}

# Step 5: Move new build files
echo "🚛 Deploying new build files..."
mv dist/* "$FRONTEND_DEPLOY_DIR"/ || { 
    echo "❌ Error: Moving files failed!"; 
    handle_move_failure
 }

# Step 6: Set correct permissions
echo "🔑 Setting correct file permissions..."
chown -R www-data:www-data "$FRONTEND_DEPLOY_DIR"
chmod -R 755 "$FRONTEND_DEPLOY_DIR"

# Step 7: Restart Nginx
echo "🔄 Restarting Nginx..."
systemctl restart nginx || { echo "❌ Error: Failed to restart Nginx!"; exit 1; }

# Step 8: Deployment Complete
echo "✅ Deployment completed successfully!"
echo "🌍 Visit https://asafarim.com to check the frontend."
# *********************************************************************
# Step 4: Deploy backend
check_processes "$BACKEND_DEPLOY_DIR"
echo "🚀 Deploying Backend..."
cd "$BACKEND_DEPLOY_DIR"

# Clean old backups (keep only the newest one)
sudo mkdir -p "$BACKEND_BACKUP_DIR"
cd "$BACKEND_BACKUP_DIR" && ls -t | tail -n +2 | xargs -r rm -rf

# Function to check API health
check_health() {
    local retries=0
    local max_retries=20 # Increased to 60 seconds
    while [ $retries -lt $max_retries ]; do
        echo "Attempt $((retries + 1)) to check health..."
        response=$(curl -sk "$HEALTH_CHECK_URL" 2>&1)

        if echo "$response" | grep -q '"status":"healthy"'; then
            echo " Health check passed"
            return 0
        fi

        # Only show logs every 5 attempts to reduce noise
        if [ $((retries % 5)) -eq 0 ]; then
            echo "Recent application logs:"
            sudo journalctl -u $SERVICE_NAME -n 10 --no-pager
        fi

        # Wait longer between retries as attempts increase
        sleep_time=$((1 + retries / 10))
        echo "Waiting ${sleep_time} seconds before next attempt..."
        sleep $sleep_time
        retries=$((retries + 1))
    done

    echo " Health check failed after $max_retries attempts"
    return 1
}

# Function for rollback
rollback() {
    echo " Rolling back deployment..."
    if [ -d "${BACKEND_BACKUP_DIR}/backup_${TIMESTAMP}" ]; then
        rm -rf "$BACKEND_DEPLOY_DIR"/*
        cp -r "${BACKEND_BACKUP_DIR}/backup_${TIMESTAMP}"/* "$BACKEND_DEPLOY_DIR"/
        systemctl restart $SERVICE_NAME
        if check_health; then
            echo " Rollback successful"
        else
            echo " Rollback failed - manual intervention required"
            exit 1
        fi
    else
        echo " No backup found for rollback"
        exit 1
    fi
}

# Function to create backup
create_backup() {
    # Create a backup of the current deployment
    echo "Creating backup..."
    BACKUP_FILE="asafarim-backend_backup_$(date +%Y%m%d_%H%M%S).tar.gz"
    sudo tar -czvf "$BACKEND_BACKUP_DIR/$BACKUP_FILE" -C "$BACKEND_DEPLOY_DIR" .
}

# Function to handle publish failure
handle_publish_failure() {
    echo " Failed to publish, rolling back..."
    sudo tar -xvf "$BACKEND_BACKUP_DIR/$BACKEND_BACKUP_FILE" -C "$BACKEND_DEPLOY_DIR"
}

# Function to create systemd service file
create_service_file() {
    echo "[Unit]" > "$SERVICE_FILE"
    echo "Description=ASafariM .NET API" >> "$SERVICE_FILE"
    echo "After=network.target mysql.service" >> "$SERVICE_FILE"
    echo "" >> "$SERVICE_FILE"
    echo "[Service]" >> "$SERVICE_FILE"
    echo "WorkingDirectory=$BACKEND_DEPLOY_DIR" >> "$SERVICE_FILE"
    echo "ExecStart=/usr/bin/dotnet $BACKEND_DEPLOY_DIR/ASafariM.Api.dll" >> "$SERVICE_FILE"
    echo "User=www-data" >> "$SERVICE_FILE"
    echo "Group=www-data" >> "$SERVICE_FILE"
    echo "Restart=always" >> "$SERVICE_FILE"
    echo "RestartSec=5" >> "$SERVICE_FILE"
    echo "Environment=ASPNETCORE_ENVIRONMENT=Production" >> "$SERVICE_FILE"
    echo "Environment=ASAFARIM_ENV=production" >> "$SERVICE_FILE"
    echo "Environment=ASPNETCORE_URLS=http://0.0.0.0:5000" >> "$SERVICE_FILE"
    echo "NoNewPrivileges=true" >> "$SERVICE_FILE"
    echo "ProtectSystem=full" >> "$SERVICE_FILE"
    echo "ProtectHome=true" >> "$SERVICE_FILE"
    echo "" >> "$SERVICE_FILE"
    echo "[Install]" >> "$SERVICE_FILE"
    echo "WantedBy=multi-user.target" >> "$SERVICE_FILE"
    echo "Created systemd service file at $SERVICE_FILE"
}

# Enhanced function to check and free port 5000
free_port_5000() {
    echo "Checking if port 5000 is in use..."
    PID=$(sudo lsof -t -i:5000)
    if [ -n "$PID" ]; then
        echo "Port 5000 is in use by process $PID, killing it..."
        sudo kill -9 $PID
        sleep 5 # Wait for port to be fully released
        echo "Verifying port is free..."
        if sudo lsof -i :5000; then
            echo "Port 5000 is still in use after killing process!"
            # stop service
            echo "Stopping backend service..."
            sudo systemctl stop $SERVICE_NAME
            sleep 5
            # check again
            if sudo lsof -i :5000; then
                echo "Port 5000 is still in use after stopping service!"
                exit 1
            else
                echo "Port 5000 successfully freed"
            fi
        else
            echo "Port 5000 successfully freed"
        fi
    else
        echo "Port 5000 is available"
    fi
}

echo " Building backend..."
cd "$REPO_DIR" || {
    echo " Error: Repository directory not found!"
    exit 1
}

yarn api:build || {
    echo " Error: Build for API in Release mode failed!"
    exit 1
}

echo " Starting Backend Deployment..."
# Build backend
free_port_5000
cd "$BACKEND_DIR" || {
    echo " Error: Backend directory not found!"
    exit 1
}

# Stop the service before deployment
echo "Stopping backend service..."
sudo systemctl stop $SERVICE_NAME
sleep 5

dotnet clean || {
    echo " Error: Failed to clean!"
    exit 1
}
dotnet restore || {
    echo " Error: Failed to restore!"
    exit 1
}
dotnet build "$BACKEND_DIR" -c Release || {
    echo " Error: Build failed!"
    exit 1
}

# Publish the backend
echo " Publishing backend..."
dotnet publish --configuration Release --output "$PUBLISH_DIR" || {
    echo " Error: Publish failed!"
    handle_publish_failure
}

# Set correct permissions
echo " Setting correct permissions..."
sudo chown -R www-data:www-data "$PUBLISH_DIR"
sudo chmod -R 755 "$PUBLISH_DIR"

# Update systemd service
echo " Updating systemd service..."
if [ ! -f "$SERVICE_FILE" ]; then
    echo " The system service file $SERVICE_FILE does not exist. So, creating it..."
    echo " Creating systemd service file..."
    create_service_file
fi
sudo cp "$SERVICE_FILE" /etc/systemd/system/
sudo systemctl daemon-reload

# Restart the backend service
echo " Restarting backend service..."
sudo systemctl restart $SERVICE_NAME

# Wait for service to become ready
echo " Waiting for backend service to become ready..."
MAX_ATTEMPTS=30
ATTEMPT=0
SERVICE_READY=false

while [ $ATTEMPT -lt $MAX_ATTEMPTS ]; do
    if curl -s -o /dev/null -w "%{http_code}" "$HEALTH_CHECK_URL" | grep -q 200; then
        SERVICE_READY=true
        break
    fi
    sleep 2
    ATTEMPT=$((ATTEMPT + 1))
done

if [ "$SERVICE_READY" = false ]; then
    echo " Error: Service did not become ready within $((MAX_ATTEMPTS * 2)) seconds"
    echo " Service logs:"
    journalctl -u $SERVICE_NAME -n 50 --no-pager
    exit 1
fi

# Health check
echo " Performing health check..."
if ! check_health; then
    echo " Health check failed - attempting rollback"
    rollback
    if ! check_health; then
        echo " Health check still failing after rollback - manual intervention required"
        exit 1
    else
        echo " Rollback successful but deployment script had issues"
        exit 0
    fi
fi

echo " Backend deployment completed successfully!"
echo " API is running at $HEALTH_CHECK_URL"
exit 0


# *********************************************************************

# Step 5: Apply database migrations
echo "🔄 Applying database migrations..."
dotnet tool restore || { echo "❌ Error: Failed to restore .NET tools!"; exit 1; }
cd "$REPO_DIR" || { echo "❌ Error: Repository directory not found!"; exit 1; }
dotnet ef database update --project ./ASafariM.Infrastructure/ASafariM.Infrastructure.csproj --startup-project ./ASafariM.Api/ASafariM.Api.csproj --verbose || { echo "❌ Error: Database migration failed!"; exit 1; }

# Step 6: Restart backend service
echo "🔄 Restarting backend service..."
systemctl restart "$SERVICE_NAME" || { echo "❌ Error: Failed to restart backend service!"; exit 1; }

# **Deployment Complete**
echo
echo " ✅  Deployment completed successfully!  ✅"