using System.Text;
using System.Text.Json.Serialization;
using Core.Application.Sitemaps.Queries;
using DashboardApi.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;

using DashboardApi.WebApi.Extensions;
using DashboardApi.Infrastructure.Data;
using DashboardApi.Core.Application.Interfaces.Repositories;
using DashboardApi.Infrastructure.Data.Repositories;

namespace DashboardApi
{
    public partial class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var environment = builder.Environment;

            // Configure Kestrel
            if (environment.IsProduction())
            {
                var httpPort = Environment.GetEnvironmentVariable("HTTP_PORT") ?? "5000";

                builder.WebHost.UseKestrel(options =>
                {
                    options.ListenAnyIP(int.Parse(httpPort)); // HTTP (internal)
                });
            }
            else
            {
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

            // Add CORS Policy
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowFrontend", builder =>
                {
                    builder.WithOrigins(
                        "http://localhost:5173",
                        "https://asafarim.com",
                        "https://preview.asafarim.com",
                        "https://techdocs.asafarim.com"
                    )
                        .AllowAnyMethod()
                        .AllowAnyHeader()
                        .AllowCredentials();
                });
            });

            // Add Controllers and JSON Options
            builder.Services.AddControllers()
                .AddJsonOptions(options =>
                    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

            // Add the extracted JWT Authentication configuration
            builder.Services.AddJwtAuthentication(builder.Configuration);

            // Add Swagger Documentation using the extension method
            builder.Services.AddSwaggerDocumentation();
            // Add the database context
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                options.UseMySql(builder.Configuration.GetConnectionString("DefaultConnection"),
                ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("DefaultConnection")),
                mySqlOptions => mySqlOptions.EnableRetryOnFailure()));

            // Add Services and Repositories
            builder.Services.AddScoped<ISitemapRepository, SitemapRepository>();
            builder.Services.AddScoped<GetSitemapQuery>();
            builder.Services.AddScoped<UserService>();

            var app = builder.Build();

            // Development-only middleware
            if (app.Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "ASafariM API V1"));
            }

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
