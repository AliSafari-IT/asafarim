using System.IO;
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
using Google.Protobuf.WellKnownTypes;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Serilog;
using Swashbuckle.AspNetCore.SwaggerGen;

var logDirectory =
    (Environment.GetEnvironmentVariable("ASAFARIM_ENV") == "production")
        ? "/var/www/asafarim/logs"
        : "E:/ASafariM/Logs";

if (!Directory.Exists(logDirectory))
{
    Directory.CreateDirectory(logDirectory);
}

Serilog.Debugging.SelfLog.Enable(Console.Error);

var logFilePath = Path.Combine(logDirectory, $"log-api_.log");
Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Information()
    .WriteTo.Console()
    .WriteTo.File(
        logFilePath,
        rollingInterval: RollingInterval.Day,
        retainedFileCountLimit: 2,
        outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss} [{Level}] {Message}{NewLine}{Exception}"
    )
    .CreateLogger();
Log.Information("Serilog configured successfully.");
Log.Information("Starting up the application...");

try
{
    var builder = WebApplication.CreateBuilder(args);

    // Add Serilog to the container
    builder.Host.UseSerilog();
    builder.Services.AddSingleton(Log.Logger);

    // Configure DbContext
    var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
    builder.Services.AddDbContext<AppDbContext>(options =>
        options.UseMySql(
            connectionString,
            new MySqlServerVersion(new Version(8, 0, 31)), // Adjust version as needed
            mySqlOptions =>
                mySqlOptions.EnableRetryOnFailure(
                    maxRetryCount: 5,
                    maxRetryDelay: TimeSpan.FromSeconds(10),
                    errorNumbersToAdd: null
                )
        )
    );

    Log.Information("DbContext configured successfully.");

    // Call the RegisterServices method
    ServiceRegistration.RegisterServices(builder);

    // Add CORS
    builder.Services.AddCors(options =>
    {
        options.AddPolicy(
            "AllowFrontend",
            builder =>
            {
                builder
                    .WithOrigins(
                        "http://localhost:3000",
                        "asafarim.com",
                        "https://www.asafarim.com",
                        "www.asafarim.com"
                    ) // Frontend URL
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .AllowCredentials();
            }
        );
    });

    Log.Information("CORS policy configured.");

    // Register AutoMapper with all profiles
    builder.Services.AddAutoMapper(cfg =>
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

    Log.Information("AutoMapper profiles registered.");

    // Register MVC with controllers from all assemblies
    builder
        .Services.AddMvc()
        .AddApplicationPart(
            typeof(ASafariM.Presentation.Controllers.MarkdownFilesController).Assembly
        )
        .AddControllersAsServices();

    // Register controllers and API explorer
    builder.Services.AddControllers();
    builder.Services.AddEndpointsApiExplorer();

    builder
        .Services.AddAuthentication(options =>
        {
            options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
        })
        .AddJwtBearer(options =>
        {
            var jwtSettings = builder.Configuration.GetSection("Jwt");
            var key = System.Text.Encoding.ASCII.GetBytes(jwtSettings["Key"] ?? "your-default-secret-key-here-minimum-16-characters");
            
            options.TokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuer = true,
                ValidateAudience = true,
                ValidateLifetime = true,
                ValidateIssuerSigningKey = true,
                ValidIssuer = jwtSettings["Issuer"] ?? "asafarim.com",
                ValidAudience = jwtSettings["Audience"] ?? "asafarim.com",
                IssuerSigningKey = new SymmetricSecurityKey(key)
            };
        });

    Log.Information("JWT authentication configured.");

    builder.Services.AddSwaggerGen();
    builder.Services.AddCors(options =>
    {
        options.AddPolicy(
            "AllowAll",
            policy =>
            {
                policy.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
            }
        );
    });

    var app = builder.Build();
    Log.Information("Application started.");

    // Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI(c =>
        {
            c.SwaggerEndpoint("/swagger/v1/swagger.json", "ASafariM API V1");
            c.RoutePrefix = "swagger";
        });
    }

    app.UseHttpsRedirection();
    app.UseRouting();

    // Use CORS before auth
    app.UseCors("AllowFrontend");

    // Add static files middleware
    app.UseStaticFiles();

    app.UseAuthentication();
    app.UseAuthorization();

    // Ensure the inline middleware is correctly implemented
    app.Use(
        async (context, next) =>
        {
            Log.Information(
                "Request: {Method} {Path} → {ContentType}",
                context.Request.Method,
                context.Request.Path,
                context.Request.ContentType
            );
            await next.Invoke();
        }
    );

    // Map controllers after all middleware
    app.MapControllers();

    app.Run();
}
catch (Exception ex)
{
    Log.Fatal(ex, "Failed to create the application builder.");
    throw;
}
finally
{
    Log.CloseAndFlush();
}
