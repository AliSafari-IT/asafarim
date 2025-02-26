#!/bin/bash

# Function to display the menu
show_menu() {
    echo "Entity Framework Migration Manager"
    echo "================================="
    echo "1. Add Migration"
    echo "2. Update Database (Development)"
    echo "3. Update Database (Server)"
    echo "4. Remove All Migrations and Update Database (Development)"
    echo "5. Remove All Migrations and Update Database (Server)"
    echo "6. Remove a Single Migration"
    echo "7. List All Migrations"
    echo "8. Generate SQL Script"
    echo "9. Display Database Information"
    echo "0. Exit"
    echo "================================="
    echo -n "Enter your choice: "
}

# Function to execute the selected action
execute_action() {
    # Change to the root directory first
    cd "$(dirname "$0")/../../"
    
    case $1 in
    1)
        echo "Adding a new migration..."
        read -p "Enter migration name: " migration_name
        dotnet ef migrations add $migration_name \
            --project "$(pwd)/ASafariM.Infrastructure/ASafariM.Infrastructure.csproj" \
            --startup-project "$(pwd)/ASafariM.Api/ASafariM.Api.csproj" \
            --verbose
        ;;
    2)        echo "Updating database (Development)..."
        dotnet ef database update --project ./ASafariM.Infrastructure/ASafariM.Infrastructure.csproj --startup-project ./ASafariM.Api/ASafariM.Api.csproj --verbose
        ;;
    3)
        echo "Updating database (Server)..."
        dotnet ef database update --project ./ASafariM.Infrastructure/ASafariM.Infrastructure.csproj --startup-project ./ASafariM.Api/ASafariM.Api.csproj --verbose
        ;;
    4)
        echo "Removing all migrations and updating database (Development)..."
        dotnet ef database update PreviousMigrationName --project ./ASafariM.Infrastructure/ASafariM.Infrastructure.csproj --startup-project ./ASafariM.Api/ASafariM.Api.csproj --verbose
        ;;
    5)
        echo "Removing all migrations and updating database (Server)..."
        dotnet ef database update PreviousMigrationName --project ./ASafariM.Infrastructure/ASafariM.Infrastructure.csproj --startup-project ./ASafariM.Api/ASafariM.Api.csproj --verbose
        ;;
    6)
        echo "Removing a single migration..."
        dotnet ef migrations remove --project ./ASafariM.Infrastructure/ASafariM.Infrastructure.csproj --startup-project ./ASafariM.Api/ASafariM.Api.csproj --verbose
        ;;
    7)
        echo "Listing all migrations..."
        dotnet ef migrations list --project ./ASafariM.Infrastructure/ASafariM.Infrastructure.csproj --startup-project ./ASafariM.Api/ASafariM.Api.csproj --verbose
        ;;
    8)
        echo "Generating SQL script..."
        dotnet ef database script --project ./ASafariM.Infrastructure/ASafariM.Infrastructure.csproj --startup-project ./ASafariM.Api/ASafariM.Api.csproj --output ./migrations/migration.sql --verbose
        ;;
    9)
        echo "Displaying database information..."
        dotnet ef database info --project ./ASafariM.Infrastructure/ASafariM.Infrastructure.csproj --startup-project ./ASafariM.Api/ASafariM.Api.csproj --verbose
        ;;
    0)
        echo "Exiting..."
        exit 0
        ;;
    *)
        echo "Invalid choice. Please try again."
        ;;
    esac
}

# Main loop
while true; do
    show_menu
    read choice
    execute_action $choice
    echo "Press Enter to continue..."
    read
done
