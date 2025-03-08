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
FRONTEND_BACKUP_PATH="$FRONTEND_BACKUP_DIR/$FRONTEND_BACKUP_FILE"
BACKEND_BACK_PATH="$BACKEND_BACKUP_DIR/$BACKEND_BACKUP_FILE"
PUBLISH_DIR="$REPO_DIR/backend"
SERVICE_NAME="asafarim-api"
SERVICE_FILE="/tmp/$SERVICE_NAME.service"
MAX_RETRIES=5
HEALTH_CHECK_URL="https://asafarim.com/api/health"
LOG_DIR="/var/log/asafarim"

# Deploy Mode (1: Frontend, 2: Backend, 3: Both)
DEPLOY_MODE=2

# Function to check if a git pull is needed
update_repo() {
    cd "$1" || {
        echo " Error: Directory not found - $1"
        exit 1
    }

    # Check if there are updates on remote
    echo " Checking for updates in $1..."
    CURRENT_BRANCH=$(git rev-parse --abbrev-ref HEAD)
    git fetch origin "$CURRENT_BRANCH"

    LOCAL_COMMIT=$(git rev-parse HEAD)
    REMOTE_COMMIT=$(git rev-parse "origin/$CURRENT_BRANCH")

    if [ "$LOCAL_COMMIT" != "$REMOTE_COMMIT" ]; then
        echo " Updates found! Pulling latest changes..."
        git pull origin "$CURRENT_BRANCH" || {
            echo " Error: Git pull failed!"
            exit 1
        }
    else
        echo " No updates needed."
    fi
}

# Function to check for running processes using files
check_processes() {
    cd "$1" || {
        echo " Error: Directory not found - $1"
        exit 1
    }
    echo " Checking for running processes in $1..."

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
            if ((percent % 10 == 0 && percent != last_percent)); then
                echo -n "•"
                echo -n ">$percent%"
                last_percent=$percent
            fi
        fi
    done

    echo "] 100% Completed"
    echo " Completed checking for running processes in $1."
}

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
    if [ -d "$BACKEND_BACKUP_PATH" ]; then
        rm -rf "$BACKEND_DEPLOY_DIR"/*
        sudo tar -xvf "$BACKEND_BACKUP_PATH" -C "$BACKEND_DEPLOY_DIR"
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

# Function to handle publish failure
handle_publish_failure() {
    echo " Failed to publish, rolling back..."
    sudo tar -xvf "$BACKEND_BACKUP_DIR/$BACKUP_FILE" -C "$BACKEND_DEPLOY_DIR"
}

# Function to create systemd service file
create_service_file() {
    echo "[Unit]" >"$SERVICE_FILE"
    echo "Description=ASafariM .NET API" >>"$SERVICE_FILE"
    echo "After=network.target mysql.service" >>"$SERVICE_FILE"
    echo "" >>"$SERVICE_FILE"
    echo "[Service]" >>"$SERVICE_FILE"
    echo "WorkingDirectory=$BACKEND_DEPLOY_DIR" >>"$SERVICE_FILE"
    echo "ExecStart=/usr/bin/dotnet $BACKEND_DEPLOY_DIR/ASafariM.Api.dll" >>"$SERVICE_FILE"
    echo "User=www-data" >>"$SERVICE_FILE"
    echo "Group=www-data" >>"$SERVICE_FILE"
    echo "Restart=always" >>"$SERVICE_FILE"
    echo "RestartSec=5" >>"$SERVICE_FILE"
    echo "Environment=ASPNETCORE_ENVIRONMENT=Production" >>"$SERVICE_FILE"
    echo "Environment=ASAFARIM_ENV=production" >>"$SERVICE_FILE"
    echo "Environment=ASPNETCORE_URLS=http://0.0.0.0:5000" >>"$SERVICE_FILE"
    echo "NoNewPrivileges=true" >>"$SERVICE_FILE"
    echo "ProtectSystem=full" >>"$SERVICE_FILE"
    echo "ProtectHome=true" >>"$SERVICE_FILE"
    echo "" >>"$SERVICE_FILE"
    echo "[Install]" >>"$SERVICE_FILE"
    echo "WantedBy=multi-user.target" >>"$SERVICE_FILE"
    echo "Created systemd service file at $SERVICE_FILE"
}

# Aggressive function to check and free port 5000
ensure_port_5000_free() {
    local max_attempts=5
    local attempt=0
    while [ $attempt -lt $max_attempts ]; do
        echo "Attempt $((attempt + 1)) to free port 5000..."
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
                    attempt=$((attempt + 1))
                else
                    echo "Port 5000 successfully freed"
                    return 0
                fi
            else
                echo "Port 5000 successfully freed"
                return 0
            fi
        else
            echo "Port 5000 is available"
            return 0
        fi
    done
    echo "Failed to free port 5000 after $max_attempts attempts"
    exit 1
}

# Step 1: Check for updates in asafarim repository
update_repo "$REPO_DIR"

# *********************************************************************
# Step 3: Deploy frontend
echo " Deploying Frontend..."
cd "$FRONTEND_DIR"

if [ "$DEPLOY_MODE" -eq 1 ] || [ "$DEPLOY_MODE" -eq 3 ]; then
    echo " Starting Frontend Deployment..."

    # Clean old backups (keep only the last newest one)
    echo " Cleaning old frontend tar-zipped backups except the last one..."
    sudo mkdir -p "$FRONTEND_BACKUP_DIR"
    cd "$FRONTEND_BACKUP_DIR" && ls -t | tail -n +2 | xargs -r rm -rf

    # Create a backup of the current deployment
    echo "Creating backup..."
    sudo tar -czvf "$FRONTEND_BACKUP_PATH" -C "$FRONTEND_DEPLOY_DIR" .

    # Step 1: Navigate to frontend project
    cd "$FRONTEND_DIR" || {
        echo " Error: Frontend directory not found!"
        exit 1
    }

    # Step 2: Build the frontend
    echo " Building frontend..."
    yarn build:npx || {
        echo " Error: Build failed!"
        exit 1
    }

    # Step 3: Ensure Deployment Directory Exists
    echo " Ensuring deployment directory exists..."
    mkdir -p "$FRONTEND_DEPLOY_DIR"

    # Step 4: Clear old files
    echo " Cleaning old deployment files..."
    rm -rf "$FRONTEND_DEPLOY_DIR"/*

    # Function to handle move failure
    handle_move_failure() {
        echo " Failed to move files, rolling back..."
        sudo tar -xvf "$FRONTEND_BACKUP_PATH" -C "$FRONTEND_DEPLOY_DIR"
    }

    # Step 5: Move new build files
    echo " Deploying new build files..."
    mv dist/* "$FRONTEND_DEPLOY_DIR"/ || {
        echo " Error: Moving files failed!"
        handle_move_failure
    }

    # Step 6: Set correct permissions
    echo " Setting correct file permissions..."
    chown -R www-data:www-data "$FRONTEND_DEPLOY_DIR"
    chmod -R 755 "$FRONTEND_DEPLOY_DIR"

    # Step 7: Restart Nginx
    echo " Restarting Nginx..."
    systemctl restart nginx || {
        echo " Error: Failed to restart Nginx!"
        exit 1
    }

    # Step 8: Deployment Complete
    echo " Deployment completed successfully!"
    echo " Visit https://asafarim.com to check the frontend."
fi
# *********************************************************************
if [ "$DEPLOY_MODE" -eq 2 ] || [ "$DEPLOY_MODE" -eq 3 ]; then
    echo " Deploying Backend..."
    cd "$BACKEND_DIR"

    # Clean old backups (keep only the last newest one)
    echo " Cleaning old backend tar-zipped backups except the last one..."
    sudo mkdir -p "$BACKEND_BACKUP_DIR"
    cd "$BACKEND_BACKUP_DIR" && ls -t | tail -n +2 | xargs -r rm -rf

    # Create a backup of the current deployment
    echo "Creating backup..."
    sudo tar -czvf "$BACKEND_BACK_PATH" -C "$BACKEND_DEPLOY_DIR" .

    # Step 1: Navigate to backend project
    create_backup() {
        echo "Creating backend backup..."

        # Ensure backup directory exists with correct permissions
        sudo mkdir -p "$BACKEND_BACKUP_DIR"
        sudo chown -R www-data:www-data "$BACKEND_BACKUP_DIR"
        sudo chmod -R 755 "$BACKEND_BACKUP_DIR"

        # Verify source directory exists and has content
        if [ ! -d "$BACKEND_DEPLOY_DIR" ]; then
            echo "Error: Source directory $BACKEND_DEPLOY_DIR does not exist"
            return 1
        fi

        if [ -z "$(ls -A $BACKEND_DEPLOY_DIR)" ]; then
            echo "Warning: Source directory $BACKEND_DEPLOY_DIR is empty"
            return 0
        fi

        # Verify file accessibility
        echo "Verifying file accessibility..."
        find "$BACKEND_DEPLOY_DIR" -type f -exec test -r {} \; -exec echo "Accessible: {}" \; || {
            echo "Error: Some files are not accessible"
            return 1
        }

        # Create backup with retry logic and detailed logging
        local retries=3
        local attempt=0

        while [ $attempt -lt $retries ]; do
            echo "Backup attempt $((attempt + 1)) of $retries..."
            if sudo tar -czvf "$BACKEND_BACKUP_PATH" -C "$BACKEND_DEPLOY_DIR" . 2>backup_errors.log; then
                echo "Backup created successfully at $BACKEND_BACKUP_PATH"
                return 0
            else
                attempt=$((attempt + 1))
                echo "Backup attempt $attempt failed. Errors:"
                cat backup_errors.log
                sleep 2
            fi
        done

        echo "Error: Backup creation failed after $retries attempts"
        return 1
    }

    # Clean old backups (keep only the newest one)
    sudo mkdir -p "$BACKEND_BACKUP_DIR"
    sudo chown -R www-data:www-data "$BACKEND_DEPLOY_DIR"
    sudo chmod -R 755 "$BACKEND_DEPLOY_DIR"

    cd "$BACKEND_BACKUP_DIR" && ls -t | tail -n +2 | xargs -r rm -rf

    # Create a backup of the current deployment
    echo "Creating backup..."
    create_backup

    ensure_port_5000_free

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
    cd "$BACKEND_DIR" || {
        echo " Error: Backend directory not found!"
        exit 1
    }

    # Stop the service before deployment
    echo "Stopping backend service..."
    sudo systemctl stop $SERVICE_NAME
    sleep 5

    # Ensure the publish directory is correctly specified
    sudo mkdir -p "$PUBLISH_DIR"

    # Handle port 5000 conflicts
    kill_process_on_port() {
        local port=$1
        echo "Checking for processes on port $port..."
        local pids=$(lsof -ti :$port)
        if [ -n "$pids" ]; then
            echo "Killing processes on port $port: $pids"
            kill -9 $pids
        else
            echo "No processes found on port $port."
        fi
    }

    # Kill any processes using port 5000
    kill_process_on_port 5000

    # Publish the backend
    echo " • Publishing backend ..."
    # Run publish with explicit output path
    dotnet publish --configuration Release --output "$PUBLISH_DIR" --verbosity normal || {
        echo " Error: Publish failed!"
        handle_publish_failure
    }

    # Set correct permissions
    echo " • Setting correct permissions..."
    sudo chown -R www-data:www-data "$PUBLISH_DIR"
    sudo chmod -R 755 "$PUBLISH_DIR"

    # Update systemd service
    echo " • Updating systemd service..."
    if [ ! -f "$SERVICE_FILE" ]; then
        echo " The system service file $SERVICE_FILE does not exist. So, creating it..."
        echo " Creating systemd service file..."
        create_service_file
    fi

    sudo cp "$SERVICE_FILE" /etc/systemd/system/
    echo " systemd service updated."

    sudo systemctl daemon-reload
    echo " systemd daemon reloaded."

fi
# *********************************************************************

# Step 5: Apply database migrations
cd "$REPO_DIR" || {
    echo " Error: Repository directory not found!"
    exit 1
}
echo " • Applying database migrations..."
dotnet tool restore || {
    echo " Error: Failed to restore .NET tools!"
    exit 1
}

dotnet ef database update --project ./ASafariM.Infrastructure/ASafariM.Infrastructure.csproj --startup-project ./ASafariM.Api/ASafariM.Api.csproj --verbose || {
    echo " Error: Database migration failed!"
    exit 1
}

# Step 6: Restart backend service
echo " Restarting backend service..."
systemctl restart "$SERVICE_NAME" || {
    echo " Error: Failed to restart backend service!"
    exit 1
}

# **Deployment Complete**
echo
echo "  Deployment completed successfully!  "
