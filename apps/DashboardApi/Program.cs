using System.Text;
using System.Text.Json.Serialization;
using Core.Application.Interfaces.Repositories;
using Core.Application.Sitemaps.Queries;
using DashboardApi.Services;
using Infrastructure.Data;
using Infrastructure.Data.Repositories;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;

namespace DashboardApi
{
    public partial class Program
    {
        public static void Main(string[] args)
        {

            WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

            // Configure Kestrel for HTTP and HTTPS traffic
            var environment = builder.Environment;
            if (environment.IsProduction())
            {
                var httpPort = Environment.GetEnvironmentVariable("HTTP_PORT") ?? "5000";
                // var httpsPort = Environment.GetEnvironmentVariable("HTTPS_PORT") ?? "5001";

                builder.WebHost.UseKestrel(options =>
                {
                    options.ListenAnyIP(int.Parse(httpPort)); // HTTP (internal)
                                                              //       options.ListenAnyIP(int.Parse(httpsPort), listenOptions => listenOptions.UseHttps()); // HTTPS (external)
                });
            }
            else
            {
                // Default for development
                builder.WebHost.UseKestrel(options =>
                {
                    options.ListenLocalhost(5146); // HTTP (local dev)
                    options.ListenLocalhost(44337, listenOptions => listenOptions.UseHttps()); // HTTPS (local dev)
                });
            }

            // Logging
            builder.Services.AddLogging(builder =>
            {
                builder.AddConsole()
                       .AddFilter(DbLoggerCategory.Database.Command.Name, LogLevel.Information);
            });

            // CORS policy configuration
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowFrontend", builder =>
                {
                    builder.WithOrigins("http://localhost:5173", "https://asafarim.com", "https://preview.asafarim.com", "https://techdocs.asafarim.com") // Allow dev and prod origins
                           .AllowAnyMethod()
                           .AllowAnyHeader()
                           .AllowCredentials();
                });
            });

            builder.Services.AddControllers();

            builder.Services.AddEndpointsApiExplorer();
            // Add services to the container.
            builder.Services.AddControllers()
                .AddJsonOptions(options =>
                    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

            // Database Configuration
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                options.UseMySql(builder.Configuration.GetConnectionString("DefaultConnection"),
                ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("DefaultConnection")),
                mySqlOptions => mySqlOptions.EnableRetryOnFailure()));

            // JWT Configuration
            var jwtSettings = builder.Configuration.GetSection("Jwt");
            var key = Encoding.ASCII.GetBytes(jwtSettings["Key"] ?? throw new ArgumentNullException("Jwt:Key"));

            builder.Services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(options =>
            {
                options.RequireHttpsMetadata = false; // Allow HTTP for local development
                options.SaveToken = true;
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidIssuer = jwtSettings["Issuer"],
                    ValidAudience = jwtSettings["Audience"],
                    ClockSkew = TimeSpan.Zero,
                };
            });

            builder.Services.AddScoped<ISitemapRepository, SitemapRepository>();
            builder.Services.AddScoped<GetSitemapQuery>();
            builder.Services.AddScoped<UserService>();

            builder.Services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "ASafariM API", Version = "v1" });
                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    In = ParameterLocation.Header,
                    Description = "Please enter your JWT with Bearer scheme",
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer"
                });
                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
        { new OpenApiSecurityScheme { Reference = new OpenApiReference { Type = ReferenceType.SecurityScheme, Id = "Bearer" } }, new string[] { } }
                });
            });

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "ASafariM API V1"));
            }

            // Custom CORS Middleware: Here I can create a custom middleware that checks the Origin header and allows any subdomain of asafarim.com.
            app.Use(async (context, next) =>
                {
                    var origin = context.Request.Headers["Origin"].ToString();

                    // Check if the origin is a subdomain of asafarim.com
                    if (!string.IsNullOrEmpty(origin) && (origin.EndsWith(".asafarim.com") || origin == "https://asafarim.com"))
                    {
                        context.Response.Headers.Add("Access-Control-Allow-Origin", origin);
                        context.Response.Headers.Add("Access-Control-Allow-Methods", "GET, POST, PUT, DELETE, OPTIONS");
                        context.Response.Headers.Add("Access-Control-Allow-Headers", "Content-Type, Authorization");
                        context.Response.Headers.Add("Access-Control-Allow-Credentials", "true");
                    }

                    if (context.Request.Method == "OPTIONS")
                    {
                        // Handle CORS preflight requests
                        context.Response.StatusCode = 204; // No Content
                        return;
                    }

                    await next();
                });

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseCors("AllowFrontend");
            app.UseAuthentication();
            app.UseAuthorization();
            app.MapControllers();
            app.Run();

        }
    }
}