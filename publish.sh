#!/bin/bash

# Set Variables
BASE_DIR="/var/www"
JWT_SECRET="0+a0ZklJy6DVL6osEj73W6P9inMk3+Ocn8KkQoUDR78="
REPO_DIR="$BASE_DIR/asafarim"
FRONTEND_DIR="$REPO_DIR/ASafariM.Clients/asafarim-ui"
BLOG_DIR="$REPO_DIR/ASafariM.Clients/asafarim-blog"
BIBLIOGRAPHY_DIR="$REPO_DIR/ASafariM.Clients/asafarim-bibliography"
PBK_DIR="$REPO_DIR/ASafariM.Clients/asafarim-pbk"
BACKEND_DIR="$REPO_DIR/ASafariM.Api"
FRONTEND_DEPLOY_DIR="$BASE_DIR/asafarim-com/public_html"
FRONTEND_BACKUP_DIR="$REPO_DIR/backups/frontends"
BLOG_DEPLOY_DIR="$BASE_DIR/asafarim-blog/public_html"
BLOG_BACKUP_DIR="$REPO_DIR/backups/blogs"
BIBLIOGRAPHY_DEPLOY_DIR="$BASE_DIR/asafarim-bibliography/public_html"
BIBLIOGRAPHY_BACKUP_DIR="$REPO_DIR/backups/bibliography"
PBK_DEPLOY_DIR="$BASE_DIR/asafarim-pbk/public_html"
PBK_BACKUP_DIR="$REPO_DIR/backups/pbks"
BACKEND_DEPLOY_DIR="$BASE_DIR/asafarim-api"
BACKEND_BACKUP_DIR="$REPO_DIR/backups/backends"

TIMESTAMP=$(TZ=:Europe/Brussels date +%Y%m%d_%H%M%S)

CLI_DIR="$REPO_DIR/ASafariM.Clients/asafarim-cli"
CLI_DEPLOY_DIR="$BASE_DIR/asafarim-cli"
CLI_BACKUP_DIR="$REPO_DIR/backups/cli"
CLI_BACKUP_FILE="asafarim-cli_backup_${TIMESTAMP}.tar.gz"
CLI_BACKUP_PATH="$CLI_BACKUP_DIR/$CLI_BACKUP_FILE"
CLI_SERVICE_NAME="asafarim-cli"
CLI_SERVICE_FILE="/etc/systemd/system/$CLI_SERVICE_NAME.service"
FRONTEND_BACKUP_FILE="asafarim-frontend_backup_${TIMESTAMP}.tar.gz"
BLOG_BACKUP_FILE="asafarim-blog_backup_${TIMESTAMP}.tar.gz"
BIBLIOGRAPHY_BACKUP_FILE="asafarim-bibliography_backup_${TIMESTAMP}.tar.gz"
PBK_BACKUP_FILE="asafarim-pbk_backup_${TIMESTAMP}.tar.gz"
BACKEND_BACKUP_FILE="asafarim-backend_backup_${TIMESTAMP}.tar.gz"
FRONTEND_BACKUP_PATH="$FRONTEND_BACKUP_DIR/$FRONTEND_BACKUP_FILE"
BLOG_BACKUP_PATH="$BLOG_BACKUP_DIR/$BLOG_BACKUP_FILE"
BIBLIOGRAPHY_BACKUP_PATH="$BIBLIOGRAPHY_BACKUP_DIR/$BIBLIOGRAPHY_BACKUP_FILE"
PBK_BACKUP_PATH="$PBK_BACKUP_DIR/$PBK_BACKUP_FILE"
BACKEND_BACKUP_PATH="$BACKEND_BACKUP_DIR/$BACKEND_BACKUP_FILE"
PUBLISH_DIR="$BASE_DIR/asafarim-api"
SERVICE_NAME="asafarim-api"
SERVICE_FILE="/etc/systemd/system/$SERVICE_NAME.service"
MAX_RETRIES=5
HEALTH_CHECK_URL="http://localhost:5000/api/health"
LOG_DIR="/var/www/asafarim/Logs"
Environment=NODE_ENV=production
Environment=PORT=3001
# Ensure log directory exists
mkdir -p "$LOG_DIR"
DEPLOY_LOG="$LOG_DIR/deploy_$(date +%Y%m%d_%H%M%S).log"

# Log function
log() {
  echo "$(date +"%Y-%m-%d %H:%M:%S") - $1" | tee -a "$DEPLOY_LOG"
}

# Clean old log files function
clean_old_logs() {
  local log_dir=$1
  local keep_count=2

  log "Cleaning old log files in $log_dir, keeping newest $keep_count for each type"

  # Get unique log file prefixes (everything before the timestamp)
  local prefixes=$(find "$log_dir" -type f -name "*.log" | sed -E 's/(.*)_[0-9]{8}_[0-9]{6}.log$/\1/' | sort -u)

  # For each prefix, keep only the most recent files
  for prefix in $prefixes; do
    local base_prefix=$(basename "$prefix")
    log "Processing logs with prefix: $base_prefix"

    # Count files for this prefix
    local file_count=$(find "$log_dir" -type f -name "${base_prefix}_*.log" | wc -l)

    if [ "$file_count" -gt "$keep_count" ]; then
      log "Keeping $keep_count of $file_count ${base_prefix} logs"
      find "$log_dir" -type f -name "${base_prefix}_*.log" | sort -r | tail -n +$((keep_count + 1)) | xargs -r rm
      log "Removed $(($file_count - $keep_count)) old ${base_prefix} logs"
    else
      log "No old ${base_prefix} logs to remove (found $file_count)"
    fi
  done
}

# Clean old logs after creating new log file
clean_old_logs "$LOG_DIR"

# Error handling function
handle_error() {
  log "ERROR: $1"
  if [ "$2" = "exit" ]; then
    log "Exiting due to critical error"
    exit 1
  fi
}

# Deploy Mode (multiple options can be selected with comma separation)
log "******* Deploying ASafariM Application *******"
echo ""
echo "Select deployment mode (comma-separated for multiple):"
echo "1. Frontend Only"
echo "2. Backend Only"
echo "3. Both Frontend and Backend"
echo "4. Blog"
echo "5. Bibliography"
echo "6. Portfolio Builder Kit (PBK)"
echo "7. CLI App"
echo "0. Exit"
echo ""
echo "You can select multiple options using commas (e.g., '1,4,5' to deploy Frontend, Blog, and Bibliography)"
read -p "Enter deploy mode(s) (1-7, 0 to exit): " DEPLOY_MODES

# Exit if user selected 0

# Check if user wants to exit
if [[ "$DEPLOY_MODES" == "0" ]]; then
  log "Exiting..."
  exit 0
fi

# Convert comma-separated input to array
IFS=',' read -ra DEPLOY_MODE_ARRAY <<<"$DEPLOY_MODES"
log "Selected deployment modes: $DEPLOY_MODES"

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

  # First check if the service is actually running
  local service_status=$(systemctl is-active $SERVICE_NAME)
  if [ "$service_status" != "active" ]; then
    log "ERROR: Service $SERVICE_NAME is not running (status: $service_status)"
    log "Attempting to start the service..."
    sudo systemctl start $SERVICE_NAME
    sleep 5
  fi

  # Check if port 5000 is actually in use
  if ! sudo lsof -i :5000 >/dev/null 2>&1; then
    log "WARNING: Nothing is listening on port 5000!"
    log "Checking service status again..."
    sudo systemctl status $SERVICE_NAME --no-pager >>"$DEPLOY_LOG"
  fi

  while [ $retries -lt $max_retries ]; do
    log "Health check attempt $((retries + 1))..."
    response=$(curl -sk "$HEALTH_CHECK_URL" -v 2>&1)
    curl_status=$?

    # Check for HTTP 200 status code in the response
    if [[ "$response" == *"HTTP/1.1 200"* ]] || [[ "$response" == *"HTTP/2 200"* ]]; then
      log "Health check passed! (HTTP 200 OK received)"
      return 0
    fi

    # Also check for the healthy status in JSON as a fallback
    if [[ "$response" == *"\"status\":\"healthy\""* ]] || [[ "$response" == *"\"status\":\"Healthy\""* ]]; then
      log "Health check passed! (healthy status found in response)"
      return 0
    fi

    # Log curl error codes for better diagnostics
    if [ $curl_status -ne 0 ]; then
      log "Curl failed with status $curl_status"
      case $curl_status in
      7) log "Failed to connect to host or proxy" ;;
      28) log "Operation timeout" ;;
      *) log "Curl error: $curl_status" ;;
      esac
    fi

    # Only show logs every 5 attempts to reduce noise
    if [ $((retries % 5)) -eq 0 ]; then
      log "Recent application logs:"
      sudo journalctl -u $SERVICE_NAME -n 20 --no-pager >>"$DEPLOY_LOG"
      log "Checking if service is still running..."
      sudo systemctl status $SERVICE_NAME --no-pager | head -n 3 >>"$DEPLOY_LOG"
    fi

    # Wait longer between retries as attempts increase
    sleep_time=$((1 + retries / 10))
    log "Waiting ${sleep_time} seconds before next attempt..."
    sleep $sleep_time
    retries=$((retries + 1))
  done

  log "Health check failed after $max_retries attempts"
  log "Final diagnostics:"
  log "Service status: $(systemctl is-active $SERVICE_NAME)"
  log "Port 5000 in use: $(if sudo lsof -i :5000 >/dev/null 2>&1; then echo 'Yes'; else echo 'No'; fi)"
  log "Last curl response: $response"
  return 1
}

# Function for rollback
rollback() {
  log "Rolling back deployment..."
  if [ -f "$BACKEND_BACKUP_PATH" ]; then
    log "Found backup at $BACKEND_BACKUP_PATH"
    log "Stopping service before rollback..."
    sudo systemctl stop $SERVICE_NAME
    sleep 3

    log "Clearing deployment directory..."
    rm -rf "$BACKEND_DEPLOY_DIR"/* || log "Warning: Failed to clear deployment directory"

    log "Extracting backup..."
    sudo tar -xzf "$BACKEND_BACKUP_PATH" -C "$BACKEND_DEPLOY_DIR" || handle_error "Failed to extract backup" "exit"

    log "Setting correct permissions..."
    sudo chown -R www-data:www-data "$BACKEND_DEPLOY_DIR"

    log "Restarting service after rollback..."
    sudo systemctl daemon-reload
    sudo systemctl start $SERVICE_NAME
    sleep 5

    if check_health; then
      log "Rollback successful"
    else
      log "WARNING: Rollback health check failed. Checking service status:"
      sudo systemctl status $SERVICE_NAME --no-pager >>"$DEPLOY_LOG"
      handle_error "Rollback failed - manual intervention required" "exit"
    fi
  else
    handle_error "No backup found for rollback at $BACKEND_BACKUP_PATH" "exit"
  fi
}

# Function to create systemd service file
create_service_file() {
  local service_file=$1
  local service_name=$2
  local working_dir=$3
  local environment=$4
  local port=$5
  local jwt_secret=$6
  local is_cli=${7:-false}

  log "Creating systemd service file: $service_file"
  
  if [ "$is_cli" = true ]; then
    cat > "$service_file" << EOL
[Unit]
Description=ASafariM CLI Service
After=network.target

[Service]
WorkingDirectory=$working_dir
ExecStart=/usr/bin/node server.js
User=www-data
Group=www-data
Restart=always
RestartSec=5
Environment=NODE_ENV=$environment
Environment=PORT=$port
Environment=JWT_SECRET=$jwt_secret
Environment=JWT_EXPIRATION=24h

[Install]
WantedBy=multi-user.target
EOL
  else
    cat > "$service_file" << EOL
[Unit]
Description=ASafariM API Service
After=network.target

[Service]
WorkingDirectory=$working_dir
ExecStart=/usr/bin/node server.js
User=www-data
Group=www-data
Restart=always
RestartSec=5
Environment=NODE_ENV=$environment
Environment=PORT=$port
Environment=JWT_SECRET=$jwt_secret
Environment=JWT_EXPIRATION=24h

[Install]
WantedBy=multi-user.target
EOL
  fi

  if [ $? -ne 0 ]; then
    handle_error "Failed to create service file" "exit"
  fi

  # Set proper permissions
  sudo chown root:root "$service_file"
  sudo chmod 644 "$service_file"
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
    if sudo lsof -i :5000 >/dev/null 2>&1; then
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
  if sudo tar -czf "$backup_path" -C "$source_dir" . >/dev/null 2>&1; then
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
    ls -t "$backup_dir"/*.tar.gz | tail -n +$((keep_count + 1)) | xargs -r sudo rm
    log "Removed $(($file_count - $keep_count)) old backups"
  else
    log "No old backups to remove"
  fi
}

# Step 1: Check for updates in asafarim repository
update_repo "$REPO_DIR"

# Deploy PBK if mode 6 is selected
if [[ " ${DEPLOY_MODE_ARRAY[*]} " =~ " 6 " ]]; then
  log "Starting Portfolio Builder Kit (PBK) Deployment..."

  # Clean old backups
  clean_old_backups "$PBK_BACKUP_DIR"

  # Create backup of existing deployment
  if [ -d "$PBK_DEPLOY_DIR" ]; then
    create_backup "$PBK_DEPLOY_DIR" "$PBK_BACKUP_PATH" "PBK"
  fi

  # Build PBK app
  log "Building PBK app..."
  cd "$PBK_DIR" || handle_error "Failed to change to PBK directory" "exit"
  pnpm build

  # Check if build was successful
  if [ -d "$PBK_DIR/dist" ]; then
    # Ensure deployment directory exists
    log "Ensuring deployment directory exists..."
    sudo mkdir -p "$PBK_DEPLOY_DIR"

    # Clean old deployment files
    log "Cleaning old deployment files..."
    sudo rm -rf "$PBK_DEPLOY_DIR"/*

    # Deploy new build files
    log "Deploying new build files..."
    sudo cp -r "$PBK_DIR/dist"/* "$PBK_DEPLOY_DIR"/

    # Set correct permissions
    log "Setting correct file permissions..."
    sudo chown -R www-data:www-data "$PBK_DEPLOY_DIR"
    sudo chmod -R 755 "$PBK_DEPLOY_DIR"

    # Restart Nginx
    log "Restarting Nginx..."
    sudo systemctl restart nginx || handle_error "Failed to restart Nginx!" "exit"

    log "PBK deployment completed successfully!"
    log "=== DEPLOYMENT SUMMARY ==="
    log "PBK deployed to: $PBK_DEPLOY_DIR"
    log "Backup stored at: $PBK_BACKUP_PATH"
    log "Log file: $DEPLOY_LOG"
    log "=== END DEPLOYMENT SUMMARY ==="
  else
    handle_error "Build directory 'dist' not found" "exit"
  fi
fi

# Deploy CLI app if mode 7 is selected
if [[ " ${DEPLOY_MODE_ARRAY[*]} " =~ " 7 " ]]; then
  log "Starting CLI App Deployment..."

  # Clean old backups
  clean_old_backups "$CLI_BACKUP_DIR"

  # Create backup of existing CLI deployment
  if [ -d "$CLI_DEPLOY_DIR" ]; then
    create_backup "$CLI_DEPLOY_DIR" "$CLI_BACKUP_PATH" "CLI"
  fi

  # Ensure CLI deploy directory exists
  mkdir -p "$CLI_DEPLOY_DIR"

  # Copy CLI files
  log "Copying CLI files to deploy directory"
  rsync -av --delete "$CLI_DIR/" "$CLI_DEPLOY_DIR/" --exclude 'node_modules' --exclude '.git'

  # Install production dependencies
  log "Installing CLI production dependencies"
  cd "$CLI_DEPLOY_DIR" || handle_error "Failed to change to CLI deploy directory" "exit"
  pnpm install --production

  # Create or update systemd service file
  create_service_file "$CLI_SERVICE_FILE" "$CLI_SERVICE_NAME" "$CLI_DEPLOY_DIR" "production" "3001" "$JWT_SECRET" true

  # Reload systemd and restart service
  log "Reloading systemd and restarting CLI service"
  systemctl daemon-reload
  systemctl restart "$CLI_SERVICE_NAME"
  systemctl enable "$CLI_SERVICE_NAME"

  # Wait for service to start
  sleep 5

  # Check if service is running
  if ! systemctl is-active --quiet "$CLI_SERVICE_NAME"; then
    handle_error "CLI service failed to start" "continue"
  else
    log "CLI service started successfully"
  fi

  # Health check with retry logic
  log "Running CLI health check..."
  MAX_RETRIES=5
  RETRY_DELAY=10
  for i in $(seq 1 $MAX_RETRIES); do
    RESPONSE=$(curl -s http://localhost:3001/health)
    if echo "$RESPONSE" | grep -q '"status":"ok"'; then
      log "CLI authentication check passed"
      break
    elif [ $i -eq $MAX_RETRIES ]; then
      handle_error "CLI authentication check failed after $MAX_RETRIES attempts" "continue"
    else
      log "Attempt $i failed, retrying in $RETRY_DELAY seconds..."
      sleep $RETRY_DELAY
    fi
  done

  log "CLI deployment completed successfully!"
  log "=== DEPLOYMENT SUMMARY ==="
  log "CLI deployed to: $CLI_DEPLOY_DIR"
  log "Backup stored at: $CLI_BACKUP_PATH"
  log "Service name: $CLI_SERVICE_NAME"
  log "Log file: $DEPLOY_LOG"
  log "=== END DEPLOYMENT SUMMARY ==="
fi

# Step 2: Apply database migrations if requested
if [ "$DB_MODE" = "y" ]; then
  # Apply database migrations
  cd "$REPO_DIR" || handle_error "Repository directory not found!" "exit"
  log "Applying database migrations..."

  dotnet tool restore || handle_error "Failed to restore .NET tools!" "exit"

  # Run database migration and capture output
  MIGRATION_OUTPUT=$(dotnet ef database update --project ./ASafariM.Infrastructure/ASafariM.Infrastructure.csproj --startup-project ./ASafariM.Api/ASafariM.Api.csproj --verbose 2>&1)
  MIGRATION_STATUS=$?

  # Check if the error is just 'Table already exists'
  if [ $MIGRATION_STATUS -ne 0 ]; then
    if echo "$MIGRATION_OUTPUT" | grep -q "Table.*already exists"; then
      log "Warning: Some tables already exist. Continuing with deployment..."
      log "Migration output contains 'Table already exists' error - this is often safe to ignore"
    else
      log "Migration output: $MIGRATION_OUTPUT"
      handle_error "Database migration failed!" "exit"
    fi
  else
    log "Database migrations applied successfully."
  fi
fi

# *********************************************************************
# Frontend Deployment
# Check if frontend deployment (mode 1 or 3) is selected
if [[ " ${DEPLOY_MODE_ARRAY[*]} " =~ " 1 " ]] || [[ " ${DEPLOY_MODE_ARRAY[*]} " =~ " 3 " ]]; then
  log "Starting Frontend Deployment..."

  # Clean old backups
  clean_old_backups "$FRONTEND_BACKUP_DIR"

  # Create a backup of the current deployment
  create_backup "$FRONTEND_DEPLOY_DIR" "$FRONTEND_BACKUP_PATH" "frontend"

  # Navigate to frontend project
  cd "$FRONTEND_DIR" || handle_error "Frontend directory not found!" "exit"

  # Build the frontend
  log "Building frontend..."
  pnpm build || handle_error "Frontend build failed!" "exit"

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
# Check if backend deployment (mode 2 or 3) is selected
if [[ " ${DEPLOY_MODE_ARRAY[*]} " =~ " 2 " ]] || [[ " ${DEPLOY_MODE_ARRAY[*]} " =~ " 3 " ]]; then
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
  pnpm api:build || handle_error "Build for API in Release mode failed!" "exit"

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
  create_service_file "$SERVICE_FILE" "$SERVICE_NAME" "$BACKEND_DEPLOY_DIR" "production" "5000" "$JWT_SECRET" false

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

# *********************************************************************
# Blog Deployment
# Check if blog deployment (mode 4) is selected
if [[ " ${DEPLOY_MODE_ARRAY[*]} " =~ " 4 " ]]; then
  log "Starting Blog Deployment..."

  # Clean old backups
  clean_old_backups "$BLOG_BACKUP_DIR"

  # Create a backup of the current deployment
  create_backup "$BLOG_DEPLOY_DIR" "$BLOG_BACKUP_PATH" "blog"

  # Navigate to blog project
  cd "$BLOG_DIR" || handle_error "Blog directory not found!" "exit"

  # Build the blog
  log "Building blog..."
  pnpm build || handle_error "Blog build failed!" "exit"

  # Ensure Deployment Directory Exists
  log "Ensuring deployment directory exists..."
  sudo mkdir -p "$BLOG_DEPLOY_DIR" || true

  # Clear old files
  log "Cleaning old deployment files..."
  sudo rm -rf "$BLOG_DEPLOY_DIR"/* || true

  # Move new build files
  log "Deploying new build files..."
  if [ -d "build" ]; then
    sudo cp -r build/* "$BLOG_DEPLOY_DIR"/ || {
      log "Error: Moving files failed, rolling back..."
      sudo tar -xzf "$BLOG_BACKUP_PATH" -C "$BLOG_DEPLOY_DIR"
      handle_error "Blog deployment failed" "exit"
    }
  else
    handle_error "Build directory 'build' not found" "exit"
  fi

  # Set correct permissions
  log "Setting correct file permissions..."
  sudo chown -R www-data:www-data "$BLOG_DEPLOY_DIR"
  sudo chmod -R 755 "$BLOG_DEPLOY_DIR"

  # Restart Nginx
  log "Restarting Nginx..."
  sudo systemctl restart nginx || handle_error "Failed to restart Nginx!" "exit"

  log "Blog deployment completed successfully!"
fi

# *********************************************************************
# Bibliography Deployment
# Check if bibliography deployment (mode 5) is selected
if [[ " ${DEPLOY_MODE_ARRAY[*]} " =~ " 5 " ]]; then
  log "Starting Bibliography Deployment..."

  # Clean old backups
  clean_old_backups "$BIBLIOGRAPHY_BACKUP_DIR"

  # Create a backup of the current deployment
  create_backup "$BIBLIOGRAPHY_DEPLOY_DIR" "$BIBLIOGRAPHY_BACKUP_PATH" "bibliography"

  # Navigate to bibliography project
  cd "$BIBLIOGRAPHY_DIR" || handle_error "Bibliography directory not found!" "exit"

  # Build the bibliography app
  log "Building bibliography app..."
  pnpm build || handle_error "Bibliography build failed!" "exit"

  # Ensure Deployment Directory Exists
  log "Ensuring deployment directory exists..."
  sudo mkdir -p "$BIBLIOGRAPHY_DEPLOY_DIR" || true

  # Clear old files
  log "Cleaning old deployment files..."
  sudo rm -rf "$BIBLIOGRAPHY_DEPLOY_DIR"/* || true

  # Move new build files
  log "Deploying new build files..."
  if [ -d "dist" ]; then
    sudo cp -r dist/* "$BIBLIOGRAPHY_DEPLOY_DIR"/ || {
      log "Error: Moving files failed, rolling back..."
      sudo tar -xzf "$BIBLIOGRAPHY_BACKUP_PATH" -C "$BIBLIOGRAPHY_DEPLOY_DIR"
      handle_error "Bibliography deployment failed" "exit"
    }
  else
    handle_error "Build directory 'dist' not found" "exit"
  fi

  # Set correct permissions
  log "Setting correct file permissions..."
  sudo chown -R www-data:www-data "$BIBLIOGRAPHY_DEPLOY_DIR"
  sudo chmod -R 755 "$BIBLIOGRAPHY_DEPLOY_DIR"

  # Restart Nginx
  log "Restarting Nginx..."
  sudo systemctl restart nginx || handle_error "Failed to restart Nginx!" "exit"

  log "Bibliography deployment completed successfully!"
fi

# *********************************************************************
# PBK Deployment
# Check if PBK deployment (mode 6) is selected
if [[ " ${DEPLOY_MODE_ARRAY[*]} " =~ " 6 " ]]; then
  log "Starting Portfolio Builder Kit (PBK) Deployment..."

  # Clean old backups
  clean_old_backups "$PBK_BACKUP_DIR"

  # Create a backup of the current deployment
  create_backup "$PBK_DEPLOY_DIR" "$PBK_BACKUP_PATH" "pbk"

  # Navigate to PBK project
  cd "$PBK_DIR" || handle_error "PBK directory not found!" "exit"

  # Build the PBK app
  log "Building PBK app..."
  pnpm build || handle_error "PBK build failed!" "exit"

  # Ensure Deployment Directory Exists
  log "Ensuring deployment directory exists..."
  sudo mkdir -p "$PBK_DEPLOY_DIR" || true

  # Clear old files
  log "Cleaning old deployment files..."
  sudo rm -rf "$PBK_DEPLOY_DIR"/* || true

  # Move new build files
  log "Deploying new build files..."
  if [ -d "dist" ]; then
    sudo cp -r dist/asafarim-pbk/browser/* "$PBK_DEPLOY_DIR"/ || {
      log "Error: Moving files failed, rolling back..."
      sudo tar -xzf "$PBK_BACKUP_PATH" -C "$PBK_DEPLOY_DIR"
      handle_error "PBK deployment failed" "exit"
    }
  else
    handle_error "Build directory 'dist' not found" "exit"
  fi

  # Set correct permissions
  log "Setting correct file permissions..."
  sudo chown -R www-data:www-data "$PBK_DEPLOY_DIR"
  sudo chmod -R 755 "$PBK_DEPLOY_DIR"

  # Restart Nginx
  log "Restarting Nginx..."
  sudo systemctl restart nginx || handle_error "Failed to restart Nginx!" "exit"

  log "PBK deployment completed successfully!"
  log "=== DEPLOYMENT SUMMARY ==="
  log "PBK deployed to: $PBK_DEPLOY_DIR"
  log "Backup stored at: $PBK_BACKUP_PATH"
  log "Log file: $DEPLOY_LOG"
  log "=== END DEPLOYMENT SUMMARY ==="

fi

# *********************************************************************
# CLI Deployment
# Check if CLI deployment (mode 7) is selected
if [[ " ${DEPLOY_MODE_ARRAY[*]} " =~ " 7 " ]]; then
  log "Starting CLI Deployment..."

  # Clean old backups
  clean_old_backups "$CLI_BACKUP_DIR"

  # Create a backup of the current deployment
  create_backup "$CLI_DEPLOY_DIR" "$CLI_BACKUP_PATH" "cli"

  # Navigate to CLI project
  cd "$CLI_DIR" || handle_error "CLI directory not found!" "exit"

  # Build the CLI app
  log "Setting up CLI deployment..."
  
  # Create CLI deployment directory if it doesn't exist
  if [ ! -d "$CLI_DEPLOY_DIR" ]; then
    log "Creating CLI deployment directory..."
    sudo mkdir -p "$CLI_DEPLOY_DIR" || handle_error "Failed to create CLI deployment directory" "exit"
  fi

  # Clean old deployment files
  log "Cleaning old deployment files..."
  sudo rm -rf "$CLI_DEPLOY_DIR"/*

  # Deploy CLI files
  log "Deploying CLI files..."
  sudo cp -r "$CLI_DIR"/* "$CLI_DEPLOY_DIR"/

  # Set correct permissions
  log "Setting correct permissions..."
  sudo chown -R www-data:www-data "$CLI_DEPLOY_DIR"
  sudo chmod -R 755 "$CLI_DEPLOY_DIR"

  # Install dependencies
  log "Installing dependencies..."
  cd "$CLI_DEPLOY_DIR" || handle_error "Failed to change to deployment directory" "exit"
  pnpm install --prod || handle_error "Failed to install dependencies" "exit"

  log "CLI deployment completed successfully!"
  log "=== DEPLOYMENT SUMMARY ==="
  log "CLI deployed to: $CLI_DEPLOY_DIR"
  log "Backup stored at: $CLI_BACKUP_PATH"
  log "Service name: $CLI_SERVICE_NAME"
  log "Log file: $DEPLOY_LOG"
  log "=== END DEPLOYMENT SUMMARY ==="
fi

# **Deployment Complete**
log "Deployment completed successfully!"
echo
echo "  Deployment completed successfully!  "
