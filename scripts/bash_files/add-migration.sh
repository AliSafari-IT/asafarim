#!/bin/bash
set -e

echo
echo "=== Adding Migration to Database ==="
echo

# Ensure the script runs from the project root
SCRIPT_DIR=$(dirname "$0")
PROJECT_ROOT=$(cd "$SCRIPT_DIR/../../" && pwd)
cd "$PROJECT_ROOT" || exit 1

# Define paths for the project and startup project
INFRASTRUCTURE_PROJECT="ASafariM.Infrastructure"
STARTUP_PROJECT="ASafariM.Api"

# Prompt for migration name
read -p "Enter migration name: " MIGRATION_NAME
if [ -z "$MIGRATION_NAME" ]; then
  echo "Migration name cannot be empty."
  exit 1
fi

echo
echo "Adding migration: $MIGRATION_NAME"
echo

# Add migration
dotnet ef migrations add "$MIGRATION_NAME" \
  --project "$INFRASTRUCTURE_PROJECT" \
  --startup-project "$STARTUP_PROJECT" \
  --verbose

echo
echo "Migration $MIGRATION_NAME added successfully."
echo

# Update database
dotnet ef database update \
  --project "$INFRASTRUCTURE_PROJECT" \
  --startup-project "$STARTUP_PROJECT" \
  --verbose

echo
echo "Database updated successfully."
echo

# click any key to exit
read -p "Press any key to exit..." -n1 -s