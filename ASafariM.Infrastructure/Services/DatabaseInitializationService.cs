using System;
using System.Threading.Tasks;
using ASafariM.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace ASafariM.Infrastructure.Services
{
    public class DatabaseInitializationService
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly ILogger<DatabaseInitializationService> _logger;

        public DatabaseInitializationService(
            IServiceProvider serviceProvider,
            ILogger<DatabaseInitializationService> logger
        )
        {
            _serviceProvider = serviceProvider;
            _logger = logger;
        }

        public async Task InitializeDatabaseAsync()
        {
            try
            {
                _logger.LogInformation("Initializing database...");

                using (var scope = _serviceProvider.CreateScope())
                {
                    var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();

                    // Check if database exists, if not create it
                    _logger.LogInformation("Ensuring database exists...");
                    await dbContext.Database.EnsureCreatedAsync();

                    // Check if migrations need to be applied
                    bool pendingMigrations = (
                        await dbContext.Database.GetPendingMigrationsAsync()
                    ).Any();
                    if (pendingMigrations)
                    {
                        _logger.LogInformation("Applying pending migrations...");
                        await dbContext.Database.MigrateAsync();
                    }

                    _logger.LogInformation("Database initialization completed successfully.");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while initializing the database.");
                throw;
            }
        }
    }
}
