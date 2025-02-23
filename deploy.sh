#!/bin/bash

# Set Variables
FRONTEND_DIR="/var/www/asafarim/ASafariM.Clients/asafarim-ui"
BACKEND_DIR="/var/www/asafarim/ASafariM.Api"
BASE_DIR="/var/www/asafarim"

echo "🚀 Starting Full Deployment..."

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

# Function to check and stop running processes
check_processes() {
    cd "$1" || { echo "❌ Error: Directory not found - $1"; exit 1; }
    echo "🔍 Checking for running processes in $1..."

    # First stop the service gracefully
    echo "Stopping asafarim-api service..."
    sudo systemctl stop asafarim-api
    sleep 5  # Give the service time to stop gracefully

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
            if pids=$(lsof -t "$file" 2>/dev/null); then
                echo "Found process using $file: $pids"
                for pid in $pids; do
                    echo "Stopping process $pid"
                    kill -15 "$pid" 2>/dev/null || true
                    sleep 1
                    kill -9 "$pid" 2>/dev/null || true
                done
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
    
    # Double check no dotnet processes are running
    if pids=$(pgrep -f "ASafariM.Api.dll"); then
        echo "Found remaining ASafariM processes: $pids"
        kill -9 $pids 2>/dev/null || true
    fi
    
    sleep 2  # Give processes time to fully stop
}

# Step 1: Check for updates in backend repository
# update_repo "$FRONTEND_DIR"  # Skip frontend for now
update_repo "$BACKEND_DIR"

# Step 2: Check for running processes using files
# check_processes "$FRONTEND_DIR"
 check_processes "$BACKEND_DIR"

# Step 3: Deploy frontend (skipped)
# echo "🚀 Deploying Frontend..."
 cd "$FRONTEND_DIR"
 ./deploy_frontend.sh || { echo "❌ Error: Frontend deployment failed!"; exit 1; }

# Step 4: Deploy backend
echo "🚀 Deploying Backend..."
cd "$BACKEND_DIR"

# Stop processes and clear any locks
check_processes "$BACKEND_DIR"

# Deploy the backend
echo "📦 Running backend deployment..."
./deploy_backend.sh || { echo "❌ Error: Backend deployment failed!"; exit 1; }

# Step 5: Apply database migrations
echo "🔄 Applying database migrations..."
dotnet tool restore || { echo "❌ Error: Failed to restore .NET tools!"; exit 1; }
cd "$BACKEND_DIR"

# Run migrations with a timeout
echo "Running database migrations..."
timeout 60 dotnet ef database update --project ASafariM.Api.csproj || { 
    echo "❌ Error: Database migration failed or timed out!"; 
    exit 1; 
}

# Step 6: Start backend service
echo "🔄 Starting backend service..."
sleep 2  # Give system time to release any file handles
sudo systemctl daemon-reload
sudo systemctl start asafarim-api || { 
    echo "❌ Error: Failed to start backend service!"; 
    echo "Checking service status..."
    sudo systemctl status asafarim-api
    exit 1; 
}

# Step 7: Verify service is running
echo "🔍 Verifying service status..."
sleep 5  # Give the service time to fully start
if ! systemctl is-active --quiet asafarim-api; then
    echo "❌ Error: Service failed to start properly!"
    sudo systemctl status asafarim-api
    exit 1
fi

# **Deployment Complete**
echo
echo " ✅  Deployment completed successfully!  ✅"

