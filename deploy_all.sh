#!/bin/bash

echo "🗑️ Removing old backend files..."
sudo rm -rf /var/www/asafarim/backend/*

echo "🚀 Publishing Backend..."
cd /var/www/asafarim/ASafariM.Api || { echo "❌ Backend directory not found!"; exit 1; }
dotnet publish -c Release -o /var/www/asafarim/backend || { echo "❌ Backend publish failed!"; exit 1; }

# Set permissions for backend
sudo chown -R www-data:www-data /var/www/asafarim/backend
sudo chmod -R 755 /var/www/asafarim/backend

# Restart API service
echo "🔄 Restarting API service..."
sudo systemctl restart asafarim-api

echo "📝 Testing API..."
curl -s http://localhost:5000/api/health

echo "🗑️ Removing old frontend files..."
sudo rm -rf /var/www/asafarim.com/public_html/*

echo "🚀 Building Frontend..."
cd /var/www/asafarim/ASafariM.Clients/asafarim-ui || { echo "❌ Frontend directory not found!"; exit 1; }
yarn install
yarn build || { echo "❌ Frontend build failed!"; exit 1; }

echo "🚛 Deploying Frontend..."
sudo cp -r dist/* /var/www/asafarim.com/public_html/

# Set permissions for frontend
sudo chown -R www-data:www-data /var/www/asafarim.com/public_html
sudo chmod -R 755 /var/www/asafarim.com/public_html

echo "✅ Deployment Completed Successfully!"
