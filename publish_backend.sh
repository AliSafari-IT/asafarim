#!/bin/bash

# Clean deployment directory
sudo rm -rf /var/www/asafarim/backend/*

cd /var/www/asafarim
yarn backend:build
# Build and publish backend
cd /var/www/asafarim/ASafariM.Api
dotnet publish -c Release -o /var/www/asafarim/backend

# Set permissions
sudo chown -R www-data:www-data /var/www/asafarim/backend
sudo chmod -R 755 /var/www/asafarim/backend

# Restart service
sudo systemctl restart asafarim-api