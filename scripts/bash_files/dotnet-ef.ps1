# Function to display the menu
function Show-Menu {
    Write-Host "Entity Framework Migration Manager"
    Write-Host "================================="
    Write-Host "1. Add Migration"
    Write-Host "2. Update Database (Development)"
    Write-Host "3. Update Database (Server)"
    Write-Host "4. Remove All Migrations and Update Database (Development)"
    Write-Host "5. Remove All Migrations and Update Database (Server)"
    Write-Host "6. Remove a Single Migration"
    Write-Host "7. List All Migrations"
    Write-Host "8. Generate SQL Script"
    Write-Host "9. Display Database Information"
    Write-Host "0. Exit"
    Write-Host "================================="
    Write-Host -NoNewline "Enter your choice: "
}

# Function to execute the selected action
function Execute-Action {
    param (
        [int]$choice
    )
    switch ($choice) {
        1 {
            $migrationName = Read-Host "Enter the migration name"
            dotnet ef migrations add $migrationName --project ./ASafariM.Infrastructure/ASafariM.Infrastructure.csproj --startup-project ./ASafariM.Api/ASafariM.Api.csproj --verbose
        }
        2 {
            dotnet ef database update --project ./ASafariM.Infrastructure/ASafariM.Infrastructure.csproj --startup-project ./ASafariM.Api/ASafariM.Api.csproj --verbose
        }
        3 {
            dotnet ef database update --project ./ASafariM.Infrastructure/ASafariM.Infrastructure.csproj --startup-project ./ASafariM.Api/ASafariM.Api.csproj --verbose
        }
        4 {
            $confirm = Read-Host "Are you sure you want to remove all migrations? (y/n)"
            if ($confirm -eq "y") {
                dotnet ef database update 0 --project ./ASafariM.Infrastructure/ASafariM.Infrastructure.csproj --startup-project ./ASafariM.Api/ASafariM.Api.csproj --verbose
            } else {
                Write-Host "Operation canceled."
            }
        }
        5 {
            $confirm = Read-Host "Are you sure you want to remove all migrations on the server? (y/n)"
            if ($confirm -eq "y") {
                dotnet ef database update 0 --project ./ASafariM.Infrastructure/ASafariM.Infrastructure.csproj --startup-project ./ASafariM.Api/ASafariM.Api.csproj --verbose
            } else {
                Write-Host "Operation canceled."
            }
        }
        6 {
            dotnet ef migrations remove --project ./ASafariM.Infrastructure/ASafariM.Infrastructure.csproj --startup-project ./ASafariM.Api/ASafariM.Api.csproj --verbose
        }
        7 {
            dotnet ef migrations list --project ./ASafariM.Infrastructure/ASafariM.Infrastructure.csproj --startup-project ./ASafariM.Api/ASafariM.Api.csproj --verbose
        }
        8 {
            $outputFile = Read-Host "Enter the output file name (e.g., migration.sql)"
            dotnet ef migrations script --output ./migrations/$outputFile --project ./ASafariM.Infrastructure/ASafariM.Infrastructure.csproj --startup-project ./ASafariM.Api/ASafariM.Api.csproj --verbose
        }
        9 {
            dotnet ef database info --project ./ASafariM.Infrastructure/ASafariM.Infrastructure.csproj --startup-project ./ASafariM.Api/ASafariM.Api.csproj --verbose
        }
        0 {
            Write-Host "Exiting..."
            exit 0
        }
        default {
            Write-Host "Invalid choice. Please try again."
        }
    }
}

# Main loop
while ($true) {
    Show-Menu
    $choice = Read-Host
    Execute-Action -choice $choice
    Write-Host "Press Enter to continue..."
    Read-Host
}