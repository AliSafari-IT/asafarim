@echo off
echo 🧹 Cleaning previous build artifacts...
if exist dist rmdir /s /q dist
if exist node_modules\.vite rmdir /s /q node_modules\.vite
if exist .vite rmdir /s /q .vite

echo 📦 Installing dependencies...
pnpm install

echo 🏗️ Building with new configuration...
pnpm run build

echo ✅ Build complete! Try deploying again.
pause
