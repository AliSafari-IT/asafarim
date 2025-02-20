#!/bin/bash

# Set Variables
FRONTEND_DIR="/d/repos/ASafariM/ASafariM.Clients/asafarim-ui"
DEPLOY_DIR="/d/repos/ASafariM/ASafariM.Clients/asafarim-ui/deploy"

echo "🚀 Starting Frontend Deployment..."

# Step 1: Navigate to frontend project
cd "$FRONTEND_DIR" || { echo "❌ Error: Frontend directory not found!"; exit 1; }

# Step 2: Install dependencies
echo "📦 Installing dependencies..."
yarn cache clean && rm -rf node_modules && rm -rf .yarn/cache && yarn install || { echo "❌ Error: Failed to install dependencies!"; exit 1; }

# Step 3: Build the frontend
echo "⚙️ Building frontend..."
yarn build || { echo "❌ Error: Build failed!"; exit 1; }

# Step 4: Ensure Deployment Directory Exists
echo "📁 Ensuring deployment directory exists..."
mkdir -p "$DEPLOY_DIR"

# Step 5: Clear old files
echo "🧹 Cleaning old deployment files..."
rm -rf "$DEPLOY_DIR"/*

# Step 6: Move new build files
echo "🚛 Deploying new build files..."
mv dist/* "$DEPLOY_DIR"/ || { echo "❌ Error: Moving files failed!"; exit 1; }

# Step 7: Deployment Complete
echo "✅ Deployment completed successfully!"
echo "🌍 Check the frontend in the deploy directory."
