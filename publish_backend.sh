#!/bin/bash

# Ensure the deployment directory exists
sudo mkdir -p /var/www/asafarim/backend

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

# Create a backup of the current deployment
echo "Creating backup..."
CURRENT_DIR="/var/www/asafarim/backend"
BACKUP_DIR="/var/www/asafarim/backups/backends"
sudo mkdir -p "$BACKUP_DIR"
BACKUP_FILE="asafarim-backend_backup_$(date +%Y%m%d_%H%M%S).tar.gz"
sudo tar -czvf "$BACKUP_DIR/$BACKUP_FILE" -C "$CURRENT_DIR" .
# Restart service
sudo systemctl restart asafarim-api