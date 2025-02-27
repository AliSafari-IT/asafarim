#!/bin/bash

# clean and install asafarim-ui working directory
if [ -d /var/www/asafarim.com/public_html ]; then
    sudo rm -rf /var/www/asafarim.com/public_html/*
fi
# clean and install root working directory and asafarim-ui
cd /var/www/asafarim
yarn clean
yarn install
yarn run ui:reinstall
yarn run ui:build

# build asafarim-ui working directory
cd /var/www/asafarim/ASafariM.Clients/asafarim-ui
sudo cp -r dist/* /var/www/asafarim.com/public_html/
sudo chown -R www-data:www-data /var/www/asafarim.com/public_html
sudo chmod -R 755 /var/www/asafarim.com/public_html

# restart nginx
sudo systemctl restart nginx

