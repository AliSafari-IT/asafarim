#!/bin/bash

# Set Variables
BASE_DIR="/var/www"
REPO_DIR="$BASE_DIR/asafarim"
FRONTEND_DIR="$REPO_DIR/ASafariM.Clients/asafarim-ui"
BACKEND_DIR="$REPO_DIR/ASafariM.Api"
FRONTEND_DEPLOY_DIR="$BASE_DIR/asafarim-com/public_html"
FRONTEND_BACKUP_DIR="$REPO_DIR/backups/frontends"
BACKEND_DEPLOY_DIR="$BASE_DIR/asafarim-api"
BACKEND_BACKUP_DIR="$REPO_DIR/backups/backends"
TIMESTAMP=$(date +%Y%m%d_%H%M%S)
FRONTEND_BACKUP_FILE="asafarim-frontend_backup_${TIMESTAMP}.tar.gz"
BACKEND_BACKUP_FILE="asafarim-backend_backup_${TIMESTAMP}.tar.gz"
FRONTEND_BACKUP_PATH="$FRONTEND_BACKUP_DIR/$FRONTEND_BACKUP_FILE"
BACKEND_BACKUP_PATH="$BACKEND_BACKUP_DIR/$BACKEND_BACKUP_FILE"
PUBLISH_DIR="$BASE_DIR/asafarim-api"
SERVICE_NAME="asafarim-api"
SERVICE_FILE="/etc/systemd/system/$SERVICE_NAME.service"
MAX_RETRIES=10
HEALTH_CHECK_URL="http://localhost:5000/api/health"
LOG_DIR="/var/www/asafarim/logs"

# Ensure log directory exists
mkdir -p "$LOG_DIR"
DEPLOY_LOG="$LOG_DIR/deploy_$(date +%Y%m%d_%H%M%S).log"

# Log function
log() {
  echo "$(date +"%Y-%m-%d %H:%M:%S") - $1" | tee -a "$DEPLOY_LOG"
}

# remove older DEPLOY_LOG files if exists except the current one
rm -f "$LOG_DIR/deploy_*.log" || true

# Error handling function
handle_error() {
  log "ERROR: $1"
  if [ "$2" = "exit" ]; then
    log "Exiting due to critical error"
    exit 1
  fi
}

# Deploy Mode (1: Frontend, 2: Backend, 3: Both)
log "******* Deploying ASafariM Application *******"
echo ""
echo " ******* Deploying ASafariM Application *******"
echo "1: Frontend"
echo "2: Backend"
echo "3: Both"
echo "0: Exit"
echo ""
read -p "Enter deploy mode: " DEPLOY_MODE

# Database Migration prompt
echo " ******* Database Migration update *******"
read -p "Apply database migration? (y/n): " DB_MODE

if [ "$DEPLOY_MODE" -eq 0 ]; then
  log "Exiting..."
  exit 0
fi

# Function to check if a git pull is needed
update_repo() {
  cd "$1" || handle_error "Directory not found - $1" "exit"

  # Check if there are updates on remote
  log "Checking for updates in $1..."
  CURRENT_BRANCH=$(git rev-parse --abbrev-ref HEAD)
  git fetch origin "$CURRENT_BRANCH"

  LOCAL_COMMIT=$(git rev-parse HEAD)
  REMOTE_COMMIT=$(git rev-parse "origin/$CURRENT_BRANCH")

  if [ "$LOCAL_COMMIT" != "$REMOTE_COMMIT" ]; then
    log "Updates found! Pulling latest changes..."
    git pull origin "$CURRENT_BRANCH" || handle_error "Git pull failed!" "exit"
    return 0
  else
    log "No updates needed."
    return 1
  fi
}

# Function to check API health
check_health() {
  local retries=0
  local max_retries=30
  log "Starting health check at $HEALTH_CHECK_URL"
  
  while [ $retries -lt $max_retries ]; do
    log "Health check attempt $((retries + 1))..."
    response=$(curl -sk "$HEALTH_CHECK_URL" 2>&1)

    if [[ "$response" == *"Healthy"* ]]; then
      log "Health check passed!"
      return 0
    fi

    # Only show logs every 5 attempts to reduce noise
    if [ $((retries % 5)) -eq 0 ]; then
      log "Recent application logs:"
      sudo journalctl -u $SERVICE_NAME -n 10 --no-pager >> "$DEPLOY_LOG"
    fi

    # Wait longer between retries as attempts increase
    sleep_time=$((1 + retries / 10))
    log "Waiting ${sleep_time} seconds before next attempt..."
    sleep $sleep_time
    retries=$((retries + 1))
  done

  log "Health check failed after $max_retries attempts"
  return 1
}

# Function for rollback
rollback() {
  log "Rolling back deployment..."
  if [ -f "$BACKEND_BACKUP_PATH" ]; then
    rm -rf "$BACKEND_DEPLOY_DIR"/*
    sudo tar -xzf "$BACKEND_BACKUP_PATH" -C "$BACKEND_DEPLOY_DIR" || handle_error "Failed to extract backup" "exit"
    log "Restarting service after rollback..."
    systemctl restart $SERVICE_NAME
    if check_health; then
      log "Rollback successful"
    else
      handle_error "Rollback failed - manual intervention required" "exit"
    fi
  else
    handle_error "No backup found for rollback at $BACKEND_BACKUP_PATH" "exit"
  fi
}

# Function to create systemd service file
create_service_file() {
  log "Creating systemd service file..."
  cat > "$SERVICE_FILE" << EOF
[Unit]
Description=ASafariM .NET API
After=network.target mysql.service

[Service]
WorkingDirectory=/var/www/asafarim-api
ExecStart=/usr/bin/dotnet /var/www/asafarim-api/ASafariM.Api.dll
User=root
Group=root
Restart=always
RestartSec=5
Environment=ASPNETCORE_ENVIRONMENT=Production
Environment=ASAFARIM_ENV=production
Environment=ASPNETCORE_URLS=http://0.0.0.0:5000
NoNewPrivileges=true
ProtectSystem=full
ProtectHome=true

[Install]
WantedBy=multi-user.target
EOF
  log "Created systemd service file at $SERVICE_FILE"
}

# Ensure port 5000 is free
ensure_port_5000_free() {
  log "Ensuring port 5000 is free..."
  
  # First try to stop the service gracefully
  sudo systemctl stop $SERVICE_NAME
  sleep 2
  
  # Check if port is still in use
  PID=$(sudo lsof -t -i:5000)
  if [ -n "$PID" ]; then
    log "Port 5000 is still in use by process $PID, killing it..."
    sudo kill -9 $PID
    sleep 2
    
    # Verify port is free
    if sudo lsof -i :5000 > /dev/null 2>&1; then
      handle_error "Failed to free port 5000" "exit"
    fi
  fi
  
  log "Port 5000 is available"
}

# Create backup function
create_backup() {
  local source_dir=$1
  local backup_path=$2
  local backup_name=$3
  
  log "Creating $backup_name backup..."

  # Ensure backup directory exists with correct permissions
  sudo mkdir -p "$(dirname "$backup_path")" || true
  sudo chown -R root:root "$(dirname "$backup_path")" || true
  sudo chmod -R 755 "$(dirname "$backup_path")" || true
  
  # Verify source directory exists and has content
  if [ ! -d "$source_dir" ]; then
    log "Warning: Source directory $source_dir does not exist, creating it..."
    sudo mkdir -p "$source_dir"
    return 0
  fi

  if [ -z "$(ls -A $source_dir 2>/dev/null)" ]; then
    log "Warning: Source directory $source_dir is empty, skipping backup"
    return 0
  fi

  # Create backup
  log "Creating backup at $backup_path"
  if sudo tar -czf "$backup_path" -C "$source_dir" . > /dev/null 2>&1; then
    log "Backup created successfully"
    return 0
  else
    handle_error "Backup creation failed" "continue"
    return 1
  fi
}

# Clean old backups function
clean_old_backups() {
  local backup_dir=$1
  local keep_count=3
  
  log "Cleaning old backups in $backup_dir, keeping newest $keep_count"
  sudo mkdir -p "$backup_dir" || true
  
  # Count files
  file_count=$(ls -1 "$backup_dir"/*.tar.gz 2>/dev/null | wc -l)
  
  if [ "$file_count" -gt "$keep_count" ]; then
    log "Removing old backups..."
    ls -t "$backup_dir"/*.tar.gz | tail -n +$((keep_count+1)) | xargs -r sudo rm
    log "Removed $(($file_count-$keep_count)) old backups"
  else
    log "No old backups to remove"
  fi
}

# Step 1: Check for updates in asafarim repository
update_repo "$REPO_DIR"

# Step 2: Apply database migrations if requested
if [ "$DB_MODE" = "y" ]; then
  # Apply database migrations
  cd "$REPO_DIR" || handle_error "Repository directory not found!" "exit"
  log "Applying database migrations..."
  
  dotnet tool restore || handle_error "Failed to restore .NET tools!" "exit"

  dotnet ef database update --project ./ASafariM.Infrastructure/ASafariM.Infrastructure.csproj --startup-project ./ASafariM.Api/ASafariM.Api.csproj --verbose || handle_error "Database migration failed!" "exit"

  log "Database migrations applied successfully."
fi

# *********************************************************************
# Frontend Deployment
if [ "$DEPLOY_MODE" -eq 1 ] || [ "$DEPLOY_MODE" -eq 3 ]; then
  log "Starting Frontend Deployment..."

  # Clean old backups
  clean_old_backups "$FRONTEND_BACKUP_DIR"

  # Create a backup of the current deployment
  create_backup "$FRONTEND_DEPLOY_DIR" "$FRONTEND_BACKUP_PATH" "frontend"

  # Navigate to frontend project
  cd "$FRONTEND_DIR" || handle_error "Frontend directory not found!" "exit"

  # Build the frontend
  log "Building frontend..."
  yarn build:npx || handle_error "Frontend build failed!" "exit"

  # Ensure Deployment Directory Exists
  log "Ensuring deployment directory exists..."
  sudo mkdir -p "$FRONTEND_DEPLOY_DIR" || true

  # Clear old files
  log "Cleaning old deployment files..."
  sudo rm -rf "$FRONTEND_DEPLOY_DIR"/* || true

  # Move new build files
  log "Deploying new build files..."
  if [ -d "dist" ]; then
    sudo cp -r dist/* "$FRONTEND_DEPLOY_DIR"/ || {
      log "Error: Moving files failed, rolling back..."
      sudo tar -xzf "$FRONTEND_BACKUP_PATH" -C "$FRONTEND_DEPLOY_DIR"
      handle_error "Frontend deployment failed" "exit"
    }
  else
    handle_error "Build directory 'dist' not found" "exit"
  fi

  # Set correct permissions
  log "Setting correct file permissions..."
  sudo chown -R www-data:www-data "$FRONTEND_DEPLOY_DIR"
  sudo chmod -R 755 "$FRONTEND_DEPLOY_DIR"

  # Restart Nginx
  log "Restarting Nginx..."
  sudo systemctl restart nginx || handle_error "Failed to restart Nginx!" "exit"

  log "Frontend deployment completed successfully!"
fi

# *********************************************************************
# Backend Deployment
if [ "$DEPLOY_MODE" -eq 2 ] || [ "$DEPLOY_MODE" -eq 3 ]; then
  log "Starting Backend Deployment..."

  # Ensure port 5000 is free
  ensure_port_5000_free

  # Clean old backups
  clean_old_backups "$BACKEND_BACKUP_DIR" || true

  # Create a backup of the current deployment
  create_backup "$BACKEND_DEPLOY_DIR" "$BACKEND_BACKUP_PATH" "backend"

  # Navigate to repository directory
  cd "$REPO_DIR" || handle_error "Repository directory not found!" "exit"

  # Build the backend
  log "Building backend..."
  yarn api:build || handle_error "Build for API in Release mode failed!" "exit"

  # Navigate to backend project
  cd "$BACKEND_DIR" || handle_error "Backend directory not found!" "exit"

  # Stop the service before deployment
  log "Stopping backend service..."
  sudo systemctl stop $SERVICE_NAME
  sleep 2

  # Ensure the publish directory exists
  log "Ensuring publish directory exists..."
  sudo mkdir -p "$PUBLISH_DIR" || true

  # Publish the backend
  log "Publishing backend..."
  dotnet publish --configuration Release --output "$PUBLISH_DIR" --verbosity normal || {
    log "Publish failed, rolling back..."
    rollback
    handle_error "Backend publish failed" "exit"
  }
  log "Backend published successfully to $PUBLISH_DIR"

  # Set correct permissions
  log "Setting correct permissions..."
  sudo chown -R root:root "$PUBLISH_DIR" || true
  sudo chmod -R 755 "$PUBLISH_DIR"
  log "Backend permissions set successfully"

  # Update systemd service
  log "Updating systemd service..."
  create_service_file

  # Reload systemd
  log "Reloading systemd daemon..."
  sudo systemctl daemon-reload || true
  log "Systemd daemon reloaded successfully"

  # Restart backend service
  log "Restarting backend service..."
  sudo systemctl restart "$SERVICE_NAME" || handle_error "Failed to restart backend service!" "exit"
  log "Backend service restarted successfully"

  # Check health
  if check_health; then
    log "Backend deployment completed successfully!"
  else
    log "Backend service is not responding to health checks, rolling back..."
    rollback
    handle_error "Backend deployment failed" "exit"
  fi
fi

# **Deployment Complete**
log "Deployment completed successfully!"
echo
echo "  Deployment completed successfully!  "
exit 0
