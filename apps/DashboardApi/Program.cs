using System.Text;
using Core.Application.Interfaces.Repositories;
using Core.Application.Sitemaps.Queries;
using DashboardApi.Services;
using Infrastructure.Data;
using Infrastructure.Data.Repositories;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Configure Kestrel for HTTP and HTTPS traffic, with environment-based ports
var environment = builder.Environment;
if (environment.IsProduction())
{
    var httpPort = Environment.GetEnvironmentVariable("HTTP_PORT") ?? "5000";
    var httpsPort = Environment.GetEnvironmentVariable("HTTPS_PORT") ?? "5001";
    
    builder.WebHost.UseKestrel(options =>
    {
        options.ListenAnyIP(int.Parse(httpPort)); // HTTP (internal)
        options.ListenAnyIP(int.Parse(httpsPort), listenOptions => listenOptions.UseHttps()); // HTTPS (external)
    });
}
else
{
    // Default for development: local development ports
    builder.WebHost.UseKestrel(options =>
    {
        options.ListenLocalhost(5146); // HTTP (local dev)
        options.ListenLocalhost(44337, listenOptions => listenOptions.UseHttps()); // HTTPS (local dev)
    });
}


// Add services to the container.
builder.Services.AddControllers();

// Configure MySQL Database and Health Checks
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseMySql(builder.Configuration.GetConnectionString("DefaultConnection"),
    ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("DefaultConnection")),
    mySqlOptions => mySqlOptions.EnableRetryOnFailure())); // Explicitly specifying MySQL options and enabling retries
// Add health checks with MySQL
builder.Services.AddHealthChecks()
    .AddDbContextCheck<ApplicationDbContext>();

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
    options.RequireHttpsMetadata = true;
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
        Title = "ASafariM API",
        Version = "v1",
        Description = "API documentation for ASafariM application"
    });
    // Add security definition for JWT in Swagger
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
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            new string[] { }
        }
    });
});

// Configure CORS for both development and production environments
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpecific", builder =>
    {
        if (environment.IsProduction())
        {
            // In development, allow all origins for testing purposes
            builder.AllowAnyOrigin()
                   .AllowAnyMethod()
                   .AllowAnyHeader();
        }
        else
        {
            // In production, restrict CORS to specific origins (e.g., your domain)
            builder.WithOrigins("https://asafarim.com")
                   .AllowAnyMethod()
                   .AllowAnyHeader()
                   .AllowCredentials();
        }
    });
});

// Build the application
var app = builder.Build();

// Add health check endpoint
app.UseHealthChecks("/health-ui");

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "ASafariM API V1");
    });
}
else
{
    app.UseHttpsRedirection(); // Ensure that HTTPS redirection is enabled in production
    app.UseHsts(); // Enforce strict transport security in production
}
// Use CORS policy
app.UseCors("AllowSpecific");

// Routing
app.UseRouting();

// Use authentication and authorization middleware
app.UseAuthentication();
app.UseAuthorization();

// Map controllers to endpoints
app.MapControllers();

app.Run();
