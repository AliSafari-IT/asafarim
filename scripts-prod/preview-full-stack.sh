#!/bin/bash

echo "Set working directory to project root: 

# Set working directory to project root /var/www/asafarim"
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
echo "Copying built React app to public directory... from apps/dashboard-client/dist to /var/www/preview.asafarim.com/public_html/"
sudo cp -r dist/* /var/www/preview.asafarim.com/public_html/

# Step 2: Build and publish the ASP.NET Core app (backend)
echo "Building the ASP.NET Core API..."
cd /var/www/asafarim/apps/DashboardApi || { echo "Directory apps/DashboardApi not found!"; exit 1; }

# Restore dependencies and publish in Release mode
dotnet restore
echo "Publishing the ASP.NET Core API... in Release mode to /var/www/preview.asafarim.com/DashboardApi"
dotnet publish -c Release -o /var/www/preview.asafarim.com/DashboardApi

if [ $? -ne 0 ]; then
  echo "ASP.NET Core API publish failed!"
  exit 1
fi

# Step 3: Restart the ASP.NET Core app (backend) to apply changes and restart Nginx
echo "Restarting ASP.NET Core API..."
sudo systemctl restart dashboardapi

# Step 3: Restart Nginx to apply changes
echo "Restarting Nginx..."
sudo systemctl restart nginx

# Step 14: Build the React documentation app (techdocs)
cd /var/www/asafarim/apps/techdocs || { echo "Directory apps/techdocs not found!"; exit 1; }
npm run build

if [ $? -ne 0 ]; then
  echo "Techdocs build failed!"
  exit 1
fi

# Copy the built React app to the public directory
echo "Copying built React app to public directory... from /var/www/asafarim/apps/techdocs/build to /var/www/asafarim.com/techdocs"
sudo cp -r build/* /var/www/preview.asafarim.com/techdocs

if [ $? -ne 0 ]; then
  echo "Techdocs copy failed!"
  exit 1
fi  

echo "Full-stack PREVIEW completed successfully!"

echo "Deployment PREVIEW successfully completed!"


