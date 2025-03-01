using System;
using System.IO;
using System.Reflection;
using ASafariM.Api;
using ASafariM.Application;
using ASafariM.Application.Mappings;
using ASafariM.Infrastructure;
using ASafariM.Infrastructure.Persistence;
using ASafariM.Presentation;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Microsoft.OpenApi.Models;
using Serilog;
using Serilog.Context;
using Serilog.Events;

// Load Environment Variables
DotNetEnv.Env.Load();
var environment = Environment.GetEnvironmentVariable("ASAFARIM_ENV") ?? "development";
Console.WriteLine($"ASAFARIM_ENV: {environment}");

// Setup Logging Directory
var logDirectory =
    environment == "production" ? "/var/www/asafarim/logs" : "D:/repos/ASafariM/Logs";
Console.WriteLine($"Log Directory: {logDirectory}");
Directory.CreateDirectory(logDirectory);
var logFilePath = Path.Combine(logDirectory, "api_.log");
Console.WriteLine($"Log File Path: {logFilePath}");

try
{
    var builder = WebApplication.CreateBuilder(args);

    // Configure Kestrel (Enable HTTP/HTTPS)
    builder.WebHost.ConfigureKestrel(options =>
    {
        options.ListenAnyIP(5000);
        options.ListenAnyIP(5001, listenOptions => listenOptions.UseHttps());
    });

    // Setup Serilog Logging
    builder.Host.UseSerilog(
        (context, services, configuration) =>
            configuration
                .MinimumLevel.Override("Microsoft", LogEventLevel.Warning)
                .MinimumLevel.Information()
                .WriteTo.Console(outputTemplate: "[{Level:u3}] {Message:lj}{NewLine}{Exception}")
                .WriteTo.File(
                    logFilePath,
                    rollingInterval: RollingInterval.Day,
                    retainedFileCountLimit: 5
                )
                .Enrich.FromLogContext()
    );

    // Register Serilog
    builder.Services.AddSingleton(Log.Logger);

    // Add Health Checks
    builder.Services.AddHealthChecks();

    // Configure Database Connection
    var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
    if (string.IsNullOrEmpty(connectionString))
    {
        throw new InvalidOperationException("Database connection string is missing");
    }

    builder.Services.AddDbContext<AppDbContext>(options =>
    {
        options.UseMySql(
            connectionString,
            new MySqlServerVersion(new Version(8, 0, 31)),
            mySqlOptions => mySqlOptions.EnableRetryOnFailure(5, TimeSpan.FromSeconds(30), null)
        );
    });

    // Register AutoMapper
    builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

    // Register Services & Repositories
    ServiceRegistration.RegisterServices(builder);
    Log.Information("Services registered successfully");

    // Configure CORS (Ensures Frontend Can Access API)
    builder.Services.AddCors(options =>
    {
        options.AddPolicy(
            "AllowFrontend",
            policy =>
            {
                policy
                    .WithOrigins(
                        "http://localhost:3000",
                        "https://localhost:3000",
                        "http://asafarim.com",
                        "https://asafarim.com"
                    )
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .AllowCredentials();
            }
        );
    });

    // Register Controllers
    builder
        .Services.AddControllers()
        .AddJsonOptions(options =>
        {
            options.JsonSerializerOptions.ReferenceHandler = System
                .Text
                .Json
                .Serialization
                .ReferenceHandler
                .Preserve;
            options.JsonSerializerOptions.MaxDepth = 64;
        })
        .AddApplicationPart(typeof(ASafariM.Presentation.Controllers.ProjectsController).Assembly);

    // Enable Swagger
    builder.Services.AddEndpointsApiExplorer();
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

    // Build the Application
    var app = builder.Build();

    // Enable Swagger for Development
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "ASafariM API V1"));
    }

    // Global Error Handling Middleware
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

    // Health Check Endpoint
    app.MapHealthChecks("/api/health");

    // Apply HTTPS Redirection (Only in Production)
    if (!app.Environment.IsDevelopment())
    {
        app.UseHttpsRedirection();
    }

    // Enable Routing
    app.UseRouting();

    // Apply CORS
    app.UseCors("AllowFrontend");

    // Enable Authentication & Authorization
    app.UseAuthentication();
    app.UseAuthorization();

    // Map Controllers
    app.MapControllers();

    // Enable Static Files
    app.UseStaticFiles();

    // Start the Application
    Log.Information("Starting the application...");
    await app.RunAsync();
}
catch (Exception ex)
{
    Log.Fatal(ex, "Application terminated unexpectedly");
    throw;
}
finally
{
    Log.Information("Shutting down application");
    Log.CloseAndFlush();
}
