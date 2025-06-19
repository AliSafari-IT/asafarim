#!/bin/bash

echo "🧹 Cleaning previous build artifacts..."
rm -rf dist/
rm -rf node_modules/.vite/
rm -rf .vite/

echo "📦 Installing dependencies..."
pnpm install

echo "🏗️ Building with new configuration..."
pnpm run build

echo "✅ Build complete! Try deploying again."
