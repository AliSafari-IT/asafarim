echo "Removing node_modules..."
rm -rf node_modules
echo "Removing yarn.lock..."
rm yarn.lock
echo "Removing .yarn/cache..."
rm -rf .yarn/cache
echo "Removing .yarn/unplugged..."
rm -rf .yarn/unplugged
echo "Removing .yarn/build-state.yml..."
rm -rf .yarn/build-state.yml

echo "Running yarn cache clean..."
yarn cache clean

echo "Running yarn install..."
yarn install
