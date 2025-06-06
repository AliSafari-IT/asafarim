using System;
using System.IO;
using System.Reflection;
using System.Text;
using System.Text.Json;
using ASafariM.Api;
using ASafariM.Api.Extensions;
using ASafariM.Application;
using ASafariM.Application.Mappings;
using ASafariM.Application.Services;
using ASafariM.Domain.Entities;
using ASafariM.Domain.Interfaces;
using ASafariM.Infrastructure;
using ASafariM.Infrastructure.Persistence;
using ASafariM.Infrastructure.Repositories;
using ASafariM.Infrastructure.Services;
using ASafariM.Presentation;
using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using MySqlConnector;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using Serilog;
using Serilog.Context;
using Serilog.Events;

// Configure logging directory
DotNetEnv.Env.Load();
var environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
Console.WriteLine($"ASPNETCORE_ENVIRONMENT: {environment}");

string baseDir = "/var/www/asafarim.be/asafarim";
string logDirectory = Path.Combine(baseDir, "logs");

try {
    if (!Directory.Exists(baseDir)) {
        Console.WriteLine($"Base directory {baseDir} does not exist");
        // Fall back to a directory we know we can write to
        logDirectory = "/tmp/asafarim/logs";
    }
    
    Console.WriteLine($"Creating log directory: {logDirectory}");
    Directory.CreateDirectory(logDirectory);
    
    // Verify we can write to it
    string testFile = Path.Combine(logDirectory, "test.txt");
    File.WriteAllText(testFile, "Test");
    File.Delete(testFile);
} catch (Exception ex) {
    Console.WriteLine($"Error creating log directory: {ex.Message}");
    // Fall back to /tmp
    logDirectory = "/tmp/asafarim/logs";
    Directory.CreateDirectory(logDirectory);
}

Console.WriteLine($"Using log directory: {logDirectory}");
var logFilePath = Path.Combine(logDirectory, "api_.log");
Console.WriteLine($"Log File Path: {logFilePath}"); // Debugging line
var line = new string('-', 100);

// Ensure ASPNETCORE_URLS is set
if (string.IsNullOrEmpty(Environment.GetEnvironmentVariable("ASPNETCORE_URLS")))
{
    Environment.SetEnvironmentVariable(
        "ASPNETCORE_URLS",
        "http://localhost:5000;https://localhost:5001;http://localhost:3005"
    );
}

try
{
    var builder = WebApplication.CreateBuilder(args);

    // Set the environment
    builder.Environment.EnvironmentName = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "Production";

    // // Configure Kestrel to listen on any IP and port
    builder.WebHost.ConfigureKestrel(options =>
    {
        options.ListenAnyIP(5000); // Listen on all network interfaces
    });

    builder.Services.AddHttpContextAccessor();

    // Configure JWT Authentication
    builder
        .Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
        .AddJwtBearer(options =>
        {
            options.TokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuer = true,
                ValidateAudience = true,
                ValidateLifetime = true,
                ValidateIssuerSigningKey = true,
                ValidIssuer = builder.Configuration["Jwt:Issuer"],
                ValidAudience = builder.Configuration["Jwt:Audience"],
                IssuerSigningKey = new SymmetricSecurityKey(
                    Encoding.ASCII.GetBytes(builder.Configuration["Jwt:Key"]!)
                ),
                ClockSkew = TimeSpan.Zero,
            };

            options.Events = new JwtBearerEvents
            {
                OnTokenValidated = context =>
                {
                    Log.Information("JWT token successfully validated");
                    return Task.CompletedTask;
                },
                OnAuthenticationFailed = context =>
                {
                    Log.Warning("JWT authentication failed: {Exception}", context.Exception);
                    return Task.CompletedTask;
                },
                OnMessageReceived = context =>
                {
                    Log.Information(
                        "JWT token received: {Token}",
                        context.Token?.Substring(0, Math.Min(10, context.Token?.Length ?? 0))
                            + "..."
                    );
                    return Task.CompletedTask;
                },
                OnChallenge = context =>
                {
                    Log.Warning("JWT authentication challenge occurred");
                    return Task.CompletedTask;
                },
            };
        });

    // Enable authorization
    builder.Services.AddAuthorization();

    // Add Serilog
    builder.Host.UseSerilog(
        (context, services, configuration) =>
            configuration
                .MinimumLevel.Override("Microsoft", LogEventLevel.Warning)
                .MinimumLevel.Override("System", LogEventLevel.Warning)
                .MinimumLevel.Information()
                .WriteTo.Console(
                    restrictedToMinimumLevel: LogEventLevel.Information,
                    outputTemplate: "[{Level:u3}] {Message:lj}{NewLine}{Exception}"
                )
                .WriteTo.File(
                    logFilePath,
                    rollingInterval: RollingInterval.Day,
                    retainedFileCountLimit: 2,
                    buffered: true,
                    flushToDiskInterval: TimeSpan.FromSeconds(1),
                    outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss} [{Level:u3}] {Message:lj}{NewLine}{Exception}"
                )
                .Enrich.FromLogContext()
    );

    // Register ILogger
    builder.Services.AddSingleton(Log.Logger);

    // Add basic services
    builder.Services.AddHealthChecks();

    // Configure DbContext with validation
    var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
    if (string.IsNullOrEmpty(connectionString))
    {
        throw new InvalidOperationException("Database connection string is missing");
    }

    // Connection string already has CharSet=utf8mb4 for emoji support

    builder.Services.AddDbContext<AppDbContext>(options =>
    {
        options
            .UseMySql(
                connectionString,
                new MySqlServerVersion(new Version(8, 0, 31)),
                mySqlOptions =>
                {
                    mySqlOptions.EnableRetryOnFailure(
                        maxRetryCount: 5,
                        maxRetryDelay: TimeSpan.FromSeconds(30),
                        errorNumbersToAdd: null
                    );
                }
            )
            .EnableSensitiveDataLogging()
            .EnableDetailedErrors();
    });

    // Configure AutoMapper
    var mapperConfig = new MapperConfiguration(cfg =>
    {
        cfg.AddMaps(
            new[]
            {
                typeof(UserMappingProfile).Assembly,
                typeof(AutoMapperProfile).Assembly,
                typeof(BlogMappingProfile).Assembly,
                typeof(PreferenceMappingProfile).Assembly,
            }
        );
    });

    IMapper mapper = mapperConfig.CreateMapper();
    builder.Services.AddSingleton(mapper);

    // Register application services
    try
    {
        // Register the database initialization service
        builder.Services.AddScoped<DatabaseInitializationService>();

        ServiceRegistration.RegisterServices(builder);
        Log.Information("Services registered successfully");
    }
    catch (Exception ex)
    {
        Log.Error(ex, "Service registration failed");
        throw;
    }

    // Configure CORS
    Log.Information("Configuring CORS...");
    builder.Services.AddCors(options =>
    {
        options.AddPolicy(
            name: "AllowFrontend",
            builder =>
            {
                builder
                    .WithOrigins(
                        "http://localhost:3000",
                        "https://localhost:3000",
                        "http://localhost:3001",
                        "https://localhost:3001",
                        "http://localhost:3002",
                        "https://localhost:3002",
                        "http://localhost:3003",
                        "https://localhost:3003",
                        "http://localhost:3004",
                        "https://localhost:3004",
                        "http://localhost:3005",
                        "https://localhost:3005",
                        "http://localhost:5000",
                        "https://localhost:5001",
                        "http://asafarim.com",
                        "https://asafarim.com",
                        "http://www.asafarim.com",
                        "https://www.asafarim.com",
                         "http://asafarim.be",
                        "https://asafarim.be",
                        "http://www.asafarim.be",
                        "https://www.asafarim.be",
                        "http://82.25.116.73"
                    )
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .AllowCredentials();
            }
        );
    });

    // Add API Controllers
    Log.Information("Configuring API Controllers...");
    builder
        .Services.AddControllers()
        .AddJsonOptions(options =>
        {
            options.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.Preserve;
            options.JsonSerializerOptions.MaxDepth = 64;
            // Add custom converters for consistent UTC DateTime handling
            options.JsonSerializerOptions.Converters.Add(new UtcDateTimeConverter());
            options.JsonSerializerOptions.Converters.Add(new UtcDateTimeNotNullableConverter());
            // Set naming policy to camelCase to match frontend JSON
            options.JsonSerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
        })
        // Chain AddApplicationPart here
        .AddApplicationPart(
            typeof(ASafariM.Presentation.Controllers.MarkdownFilesController).Assembly
        )
        .AddApplicationPart(typeof(ASafariM.Presentation.Controllers.ProjectsController).Assembly)
        .AddApplicationPart(
            typeof(ASafariM.Presentation.Controllers.BibliographyController).Assembly
        )
        .AddApplicationPart(
            typeof(ASafariM.Presentation.Controllers.HealthCheckController).Assembly
        );

    builder.Services.AddEndpointsApiExplorer();

    // Configure Swagger
    Log.Information("Configuring Swagger...");
    builder.Services.AddSwaggerGen(c =>
    {
        c.SwaggerDoc(
            "v1",
            new OpenApiInfo
            {
                Title = "ASafariM API",
                Version = "v1",
                Description = "API for ASafariM platform",
            }
        );
    });

    // Build the application
    Log.Information("Building the application...");
    var app = builder.Build();

    // Initialize the database on startup
    using (var scope = app.Services.CreateScope())
    {
        var dbInitService =
            scope.ServiceProvider.GetRequiredService<DatabaseInitializationService>();
        try
        {
            Log.Information("Initializing database...");
            dbInitService.InitializeDatabaseAsync().Wait();
            Log.Information("Database initialization completed successfully.");
        }
        catch (Exception ex)
        {
            Log.Error(ex, "An error occurred while initializing the database.");
        }
    }

    // Configure the HTTP request pipeline
    Log.Information("Configuring the HTTP request pipeline...");
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI(c =>
        {
            c.SwaggerEndpoint("/swagger/v1/swagger.json", "ASafariM API V1");
            c.RoutePrefix = "swagger";
        });
    }
    if (!app.Environment.IsDevelopment())
    {
        app.Use(
            async (context, next) =>
            {
                // Allow internal requests to stay on HTTP (needed for Nginx reverse proxy)
                if (!context.Request.Host.Host.Contains("asafarim.com"))
                {
                    context.Request.Scheme = "http";
                }
                await next();
            }
        );

        // app.UseHttpsRedirection(); // <-- This might be causing the redirect
    }

    // Global error handling
    Log.Information("Configuring global error handling...");
    app.UseExceptionHandler(errorApp =>
    {
        errorApp.Run(async context =>
        {
            context.Response.StatusCode = StatusCodes.Status500InternalServerError;
            context.Response.ContentType = "application/json";

            var error = context.Features.Get<IExceptionHandlerFeature>();
            if (error != null)
            {
                Log.Error(error.Error, "Unhandled exception");
                await context.Response.WriteAsJsonAsync(
                    new
                    {
                        Error = "An error occurred processing your request",
                        Detail = app.Environment.IsDevelopment() ? error.Error.Message : null,
                    }
                );
            }
        });
    });

    // Health check endpoint - Using custom HealthCheckController instead of built-in MapHealthChecks
    Log.Information("Configuring health check endpoint...");
    // app.MapHealthChecks("/api/system-health"); // Commented out to avoid conflict with HealthCheckController

    // HTTPS redirection (disabled for local health checks)
    app.Use(
        async (context, next) =>
        {
            if (
                !context.Request.Path.StartsWithSegments("/api/health")
                && !context.Request.IsLocal()
            )
            {
                context.Request.Scheme = "https";
            }
            await next();
        }
    );

    Log.Information("Configuring routing...");
    app.UseRouting();

    // CORS - Must be after UseRouting and before UseAuthentication
    Log.Information("Configuring CORS...");
    app.UseCors("AllowFrontend");

    // Authentication & Authorization
    Log.Information("Configuring authentication...");
    app.UseAuthentication();
    app.UseAuthorization();

    // Map Controllers
    Log.Information("Mapping controller endpoints...");
    app.MapControllers();

    // Static files
    Log.Information("Configuring static files...");
    app.UseStaticFiles();

    // Request logging middleware - Optimized version
    Log.Information("Configuring request logging middleware...");
    app.Use(
        async (context, next) =>
        {
            // Only log non-static file requests
            if (!context.Request.Path.StartsWithSegments("/static"))
            {
                using var _ = LogContext.PushProperty("RequestId", context.TraceIdentifier);
                Log.Information(
                    "HTTP {RequestMethod} {RequestPath} started",
                    context.Request.Method,
                    context.Request.Path
                );

                var sw = System.Diagnostics.Stopwatch.StartNew();
                try
                {
                    await next();
                    sw.Stop();

                    // Only log completion for non-successful responses or slow requests
                    if (context.Response.StatusCode >= 400 || sw.ElapsedMilliseconds > 500)
                    {
                        Log.Information(
                            "HTTP {RequestMethod} {RequestPath} completed in {Elapsed:0.0}ms with {StatusCode}",
                            context.Request.Method,
                            context.Request.Path,
                            sw.ElapsedMilliseconds,
                            context.Response.StatusCode
                        );
                    }
                }
                catch (Exception ex)
                {
                    sw.Stop();
                    Log.Error(
                        ex,
                        "HTTP {RequestMethod} {RequestPath} failed in {Elapsed:0.0}ms",
                        context.Request.Method,
                        context.Request.Path,
                        sw.ElapsedMilliseconds
                    );
                    throw;
                }
            }
            else
            {
                await next();
            }
        }
    );

    // Start the application
    try
    {
        Log.Information("Starting the application...");
        Log.Information("{line}", line);
        await app.RunAsync();
        Log.Information("Application stopped gracefully.");
    }
    catch (Exception ex)
    {
        Log.Fatal(ex, "Application crashed after startup.");
    }
}
catch (Exception ex)
{
    Log.Fatal(ex, "Application terminated unexpectedly");
    if (ex.InnerException != null)
    {
        Log.Fatal(ex.InnerException, "Inner exception details");
    }
    throw;
}
finally
{
    Log.Information("Shutting down application");
    Log.CloseAndFlush();
}

Log.Information("{line}", line);
