SERVER_IP="141.136.42.239"
LOCAL_FRONTEND_DIR="D:/repos/ASafariM/ASafariM.Clients/asafarim-ui"
REMOTE_DEPLOY_DIR="/var/www/asafarim.com/public_html"

cd "$LOCAL_FRONTEND_DIR" || { echo "❌ Error: Directory not found - $LOCAL_FRONTEND_DIR"; exit 1; }
echo "current directory: $(pwd)"

# Step 2: Install dependencies
echo "📦 Installing dependencies..."
yarn cache clean && rm -rf node_modules && rm -rf .yarn/cache && yarn install || { echo "❌ Error: Failed to install dependencies!"; exit 1; }

# Step 3: Build the frontend
echo "⚙️ Building frontend..."
yarn build || { echo "❌ Error: Build failed!"; exit 1; }

# Step 4: Chown the deploy directory exists
echo "📁 Ensuring deployment directory exists..."
ssh "$SERVER_IP" "mkdir -p $REMOTE_DEPLOY_DIR && sudo chown -R www-data:www-data $REMOTE_DEPLOY_DIR"

# Step 5: Copy the frontend build files (not the dist folder itself)
echo "🚀 Copying frontend build files..."
scp -r "$LOCAL_FRONTEND_DIR/dist/" root@"$SERVER_IP":"$REMOTE_DEPLOY_DIR"

# Step 6: Set correct permissions
echo "🔑 Setting correct file permissions..."
ssh "$SERVER_IP" "chown -R www-data:www-data $REMOTE_DEPLOY_DIR && chmod -R 755 $REMOTE_DEPLOY_DIR"

# Step 7: Restart Nginx
echo "🔄 Restarting Nginx..."
ssh "$SERVER_IP" 'systemctl restart nginx' || { echo "❌ Error: Failed to restart Nginx!"; exit 1; }

# Step 8: Deployment Complete
echo "✅ Deployment completed successfully!"
echo "🌍 Visit https://asafarim.com to check the frontend."
