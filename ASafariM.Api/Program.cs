using System;
using System.IO;
using System.Reflection;
using ASafariM.Api;
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
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Microsoft.OpenApi.Models;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using Serilog;
using Serilog.Events;

// Configure logging directory
var logDirectory =
    Environment.GetEnvironmentVariable("ASAFARIM_ENV") == "production"
        ? "/var/www/asafarim/logs"
        : "D:/repos/ASafariM/Logs";

Directory.CreateDirectory(logDirectory);
var logFilePath = Path.Combine(logDirectory, ".log");

try
{
    var builder = WebApplication.CreateBuilder(args);

    // Add Serilog
    builder.Host.UseSerilog(
        (context, services, configuration) =>
            configuration
                .MinimumLevel.Override("Microsoft", LogEventLevel.Warning)
                .MinimumLevel.Override("System", LogEventLevel.Warning)
                .MinimumLevel.Information()
                .WriteTo.Console()
                .WriteTo.File(
                    logFilePath,
                    rollingInterval: RollingInterval.Day,
                    retainedFileCountLimit: 2,
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
                        "https://asafarim.com",
                        "https://www.asafarim.com"
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
        .AddApplicationPart(
            typeof(ASafariM.Presentation.Controllers.MarkdownFilesController).Assembly
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

    // HTTPS redirection
    Log.Information("Configuring HTTPS redirection...");
    app.UseHttpsRedirection();

    // Routing
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

    // Request logging middleware
    Log.Information("Configuring request logging middleware...");
    app.Use(
        async (context, next) =>
        {
            Log.Information(
                "Request: {Method} {Path} → {ContentType}",
                context.Request.Method,
                context.Request.Path,
                context.Request.ContentType
            );
            await next();
        }
    );

    // Health check endpoint
    Log.Information("Configuring health check endpoint...");
    app.MapHealthChecks("/health");

    // Start the application
    try
    {
        Log.Information("Starting the application...");
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
