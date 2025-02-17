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
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Microsoft.OpenApi.Models;
using Serilog;
using Serilog.Events;

// Configure logging first
var logDirectory =
    Environment.GetEnvironmentVariable("ASAFARIM_ENV") == "production"
        ? "/var/www/asafarim/logs"
        : "E:/ASafariM/Logs";

Directory.CreateDirectory(logDirectory);
var logFilePath = Path.Combine(logDirectory, "api.log");

Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Override("Microsoft", LogEventLevel.Warning)
    .MinimumLevel.Override("System", LogEventLevel.Warning)
    .MinimumLevel.Information()
    .WriteTo.Console()
    .WriteTo.File(
        logFilePath,
        rollingInterval: RollingInterval.Hour,
        retainedFileCountLimit: 24,
        outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss} [{Level:u3}] {Message:lj}{NewLine}{Exception}"
    )
    .Enrich.FromLogContext()
    .CreateLogger();

try
{
    Log.Information("Starting up ASafariM API");

    var builder = WebApplication.CreateBuilder(args);

    // Add basic services
    builder.Host.UseSerilog();
    builder.Services.AddHealthChecks();
    builder.Services.AddLogging(loggingBuilder =>
    {
        loggingBuilder.ClearProviders();
        loggingBuilder.AddSerilog(dispose: true);
    });

    // Configure DbContext with validation
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
            mySqlOptions =>
            {
                mySqlOptions.EnableRetryOnFailure(5);
            }
        );
    });

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
    builder.Services.AddCors(options =>
    {
        options.AddPolicy(
            "AllowFrontend",
            policy =>
            {
                policy
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

    // Configure AutoMapper
    builder.Services.AddAutoMapper(config =>
    {
        config.AddMaps(
            new[]
            {
                typeof(UserMappingProfile).Assembly,
                typeof(AutoMapperProfile).Assembly,
                typeof(BlogMappingProfile).Assembly,
                typeof(PreferenceMappingProfile).Assembly,
            }
        );
    });

    // Add API Controllers
    builder
        .Services.AddControllers()
        .AddApplicationPart(
            typeof(ASafariM.Presentation.Controllers.MarkdownFilesController).Assembly
        );

    builder.Services.AddEndpointsApiExplorer();

    // Configure Swagger
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
    var app = builder.Build();

    // Validate AutoMapper configuration
    using (var scope = app.Services.CreateScope())
    {
        try
        {
            var mapper = scope.ServiceProvider.GetRequiredService<IMapper>();
            mapper.ConfigurationProvider.AssertConfigurationIsValid();
            Log.Information("AutoMapper configuration validated successfully");
        }
        catch (Exception ex)
        {
            Log.Error(ex, "AutoMapper configuration validation failed");
            throw;
        }
    }

    // Configure the HTTP request pipeline
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

    app.UseHttpsRedirection();
    app.UseRouting();
    app.UseCors("AllowFrontend");
    app.UseStaticFiles();

    // Request logging middleware
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
    app.MapHealthChecks("/health");

    // Controller endpoints
    app.MapControllers();

    // Start the application
    await app.RunAsync();
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
