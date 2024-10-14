#!/bin/bash

# Set working directory to project root
cd /var/www/asafarim

# Step 1: Build the React app (frontend)
echo "Building the React client..."
cd apps/dashboard-client
npm run build

if [ $? -ne 0 ]; then
  echo "React client build failed!"
  exit 1
fi

# Copy the built React app to the public directory
sudo cp -r dist/* /var/www/asafarim.com/public_html/

# Step 2: Build and publish the ASP.NET Core app (backend)
echo "Building the ASP.NET Core API..."
cd /var/www/asafarim/apps/DashboardApi || { echo "Directory apps/DashboardApi not found!"; exit 1; }

# Restore dependencies and publish in Release mode
dotnet restore
dotnet publish -c Release -o /var/www/asafarim.com/DashboardApi

if [ $? -ne 0 ]; then
  echo "ASP.NET Core API publish failed!"
  exit 1
fi

# Step 3: Restart Nginx to apply changes
echo "Restarting Nginx..."
sudo systemctl restart nginx

echo "Deployment completed successfully!"
