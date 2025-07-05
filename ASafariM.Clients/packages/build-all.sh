#!/bin/bash

echo "Building all shared packages in workspace..."

cd "$(dirname "$0")"

# Build packages in the correct order
echo "Building @asafarim/markdown-utils..."
cd markdown-utils && pnpm build
if [ $? -ne 0 ]; then
  echo "Error: Failed to build markdown-utils"
  exit 1
fi

echo "Building @asafarim/react-themes..."
cd ../react-themes && pnpm build
if [ $? -ne 0 ]; then
  echo "Error: Failed to build react-themes"
  exit 1
fi

echo "Building @asafarim/dd-menu..."
cd ../dd-menu && pnpm build
if [ $? -ne 0 ]; then
  echo "Error: Failed to build dd-menu"
  exit 1
fi

echo "Building @asafarim/react-privacy-consent..."
cd ../react-privacy-consent && pnpm build
if [ $? -ne 0 ]; then
  echo "Error: Failed to build react-privacy-consent"
  exit 1
fi

echo "All packages built successfully!"
