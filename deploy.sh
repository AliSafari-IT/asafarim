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

# Step 1: Check for updates in frontend and backend repositories
update_repo "$FRONTEND_DIR"
update_repo "$BACKEND_DIR"

# Step 2: Check for running processes using files
# check_processes "$FRONTEND_DIR"
 check_processes "$BACKEND_DIR"

# Step 3: Deploy frontend
echo "🚀 Deploying Frontend..."
cd "$FRONTEND_DIR"
./deploy_frontend.sh || { echo "❌ Error: Frontend deployment failed!"; exit 1; }

# Step 4: Deploy backend
echo "🚀 Deploying Backend..."
cd "$BACKEND_DIR"
check_processes "$BACKEND_DIR"

# Step 5: Apply database migrations
echo "🔄 Applying database migrations..."
dotnet tool restore || { echo "❌ Error: Failed to restore .NET tools!"; exit 1; }
cd "$BASE_DIR"
# yarn migadd || { echo "❌ Error: Migration addition failed!"; exit 1; }
 cd "$BACKEND_DIR" && dotnet ef database update --project ASafariM.Api.csproj || { echo "❌ Error: Database migration failed!"; exit 1; }

# Step 6: Restart backend service
echo "🔄 Restarting backend service..."
systemctl restart asafarim-api || { echo "❌ Error: Failed to restart backend service!"; exit 1; }

# **Deployment Complete**
echo
echo " ✅  Deployment completed successfully!  ✅"

