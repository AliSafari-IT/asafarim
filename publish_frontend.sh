#!/bin/bash

# Clean and install asafarim-ui working directory
if [ -d /var/www/asafarim.com/public_html ]; then
    echo "Cleaning public_html directory..."
    sudo rm -rf /var/www/asafarim.com/public_html/*
fi

# Clean and install root working directory and asafarim-ui
echo "Cleaning and installing dependencies..."
cd /var/www/asafarim
yarn clean --verbose
yarn install --verbose
yarn run ui:reinstall --verbose
yarn run ui:build --verbose

# Build asafarim-ui working directory
echo "Building and deploying asafarim-ui..."
cd /var/www/asafarim/ASafariM.Clients/asafarim-ui
sudo cp -r dist/* /var/www/asafarim.com/public_html/
sudo chown -R www-data:www-data /var/www/asafarim.com/public_html
sudo chmod -R 755 /var/www/asafarim.com/public_html

# Restart nginx
echo "Restarting nginx..."
sudo systemctl restart nginx

echo "Frontend deployment completed successfully."