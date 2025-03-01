#!/bin/bash

echo "🗑️ Removing old backend files..."
sudo rm -rf /var/www/asafarim/backend/*

echo "🚀 Publishing Backend..."
cd /var/www/asafarim/ASafariM.Api || { echo "❌ Error: Directory not found!"; exit 1; }
dotnet publish -c Release -o /var/www/asafarim/backend || { echo "❌ Error: Failed to publish!"; exit 1; }

# Set correct permissions
sudo chown -R www-data:www-data /var/www/asafarim/backend
sudo chmod -R 755 /var/www/asafarim/backend

# Restart API service
echo "🔄 Restarting API service..."
sudo systemctl restart asafarim-api

# Test API
echo "📝 Testing API..."
curl -s http://localhost:5000/api/health
