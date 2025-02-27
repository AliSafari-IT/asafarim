#!/bin/bash

if [ -d /var/www/asafarim.com/public_html ]; then
    sudo rm -rf /var/www/asafarim.com/public_html/*
fi

cd /var/www/asafarim/ASafariM.Clients/asafarim-ui
yarn install
yarn build
sudo cp -r dist/* /var/www/asafarim.com/public_html/
sudo chown -R www-data:www-data /var/www/asafarim.com/public_html
sudo chmod -R 755 /var/www/asafarim.com/public_html