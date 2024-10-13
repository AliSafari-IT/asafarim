using System.Text;
using Core.Application.Interfaces.Repositories;
using Core.Application.Sitemaps.Queries;
using DashboardApi.Services;
using HealthChecks.UI.Client;
using Infrastructure.Data;
using Infrastructure.Data.Repositories;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Configure Kestrel to manually set HTTP and HTTPS ports
builder.WebHost.ConfigureKestrel(options =>
{
    options.ListenLocalhost(5146); // HTTP port
    options.ListenLocalhost(44337, listenOptions => listenOptions.UseHttps()); // HTTPS port
});

// Add services to the container.
builder.Services.AddControllers();

// Configure MySQL Database and Health Checks
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseMySql(builder.Configuration.GetConnectionString("DefaultConnection"),
    ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("DefaultConnection"))));

// Add MySQL Health Check  
builder.Services.AddHealthChecks()
    .AddMySql(builder.Configuration.GetConnectionString("DefaultConnection"), 
              name: "mysql", 
              failureStatus: HealthStatus.Unhealthy);

// Add HealthChecks UI with in-memory storage
builder.Services.AddHealthChecksUI()
    .AddInMemoryStorage();

// JWT Authentication Configuration
var jwtSettings = builder.Configuration.GetSection("Jwt");
var key = Encoding.ASCII.GetBytes(jwtSettings["Key"] ?? throw new ArgumentNullException("Jwt:Key"));

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = jwtSettings["Issuer"],
        ValidAudience = jwtSettings["Audience"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings["Key"]))
    };
});

// Register services and repositories
builder.Services.AddScoped<ISitemapRepository, SitemapRepository>();
builder.Services.AddScoped<GetSitemapQuery>();
builder.Services.AddScoped<UserService>();

// Add Swagger services
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "My API",
        Version = "v1"
    });
});

// Configure CORS to allow any origin, method, and header
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", builder =>
    {
        builder.AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader();
    });
});

// Build the application
var app = builder.Build();

// HealthCheck endpoints
app.UseHealthChecks("/health", new HealthCheckOptions
{
    ResponseWriter = UIResponseWriter.WriteHealthCheckUIResponse // Provide a formatted UI response
});

// Serve the HealthChecks UI at /health-ui path
app.UseHealthChecksUI(config => config.UIPath = "/health-ui");

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
    });
}
else
{
    app.UseHttpsRedirection();
}

// Use CORS policy
app.UseCors("AllowAll");

// Routing must be done before other middleware like authentication/authorization
app.UseRouting();

// Use authentication and authorization middleware
app.UseAuthentication();
app.UseAuthorization();

// Map controllers to endpoints
app.MapControllers();

app.Run();
