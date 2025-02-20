#!/bin/bash

# Set Variables
BACKEND_DIR="/var/www/asafarim/ASafariM.Api"
PUBLISH_DIR="/var/www/asafarim/backend"

echo "🚀 Starting Backend Deployment..."

# Step 1: Navigate to backend project
cd "$BACKEND_DIR" || { echo "❌ Error: Backend directory not found!"; exit 1; }

# Step 2: Restore dependencies
echo "📦 Restoring dependencies..."
dotnet restore || { echo "❌ Error: Failed to restore dependencies!"; exit 1; }

# Step 3: Build the backend
echo "⚙️ Building backend..."
dotnet build --configuration Release || { echo "❌ Error: Build failed!"; exit 1; }

# Step 4: Publish the backend
echo "📤 Publishing backend..."
dotnet publish --configuration Release --output "$PUBLISH_DIR" || { echo "❌ Error: Publish failed!"; exit 1; }

# Step 5: Ensure correct permissions
echo "🔑 Setting correct permissions..."
chown -R www-data:www-data "$PUBLISH_DIR"
chmod -R 755 "$PUBLISH_DIR"

# Step 6: Restart the backend service
echo "🔄 Restarting backend service..."
systemctl restart asafarim-api || { echo "❌ Error: Failed to restart backend service!"; exit 1; }

# Step 7: Deployment Complete
echo "✅ Backend deployment completed successfully!"
echo "🌍 API should be running at https://asafarim.com/api/health"
