#!/bin/bash
set -e

echo
echo "=== Updating Database for a Given Migration ==="
echo

# Ensure the script runs from the project root
SCRIPT_DIR=$(dirname "$0")
PROJECT_ROOT=$(cd "$SCRIPT_DIR/../../" && pwd)
cd "$PROJECT_ROOT" || exit 1

# Define paths for the project and startup project
INFRASTRUCTURE_PROJECT="ASafariM.Infrastructure"
STARTUP_PROJECT="ASafariM.Api"

# Prompt for migration name
read -p "Enter migration name (or leave empty for latest): " MIGRATION_NAME

# Update database
if [ -z "$MIGRATION_NAME" ]; then
    echo
    echo "Updating database to the latest migration..."
    dotnet ef database update \
        --project "$INFRASTRUCTURE_PROJECT" \
        --startup-project "$STARTUP_PROJECT" \
        --verbose
else
    echo
    echo "Updating database to migration: $MIGRATION_NAME"
    dotnet ef database update "$MIGRATION_NAME" \
        --project "$INFRASTRUCTURE_PROJECT" \
        --startup-project "$STARTUP_PROJECT" \
        --verbose
fi

echo
echo "Database update completed."
echo
