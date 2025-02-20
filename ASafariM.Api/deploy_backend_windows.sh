#!/bin/bash

# Set Variables
BACKEND_DIR="D:/repos/ASafariM/ASafariM.Api"
PUBLISH_DIR="D:/repos/ASafariM/backend"

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

# Step 5: Deployment Complete
echo "✅ Backend deployment completed successfully!"
echo "🌍 API should be running at https://asafarim.com/api/health"
