using System.Text;
using Core.Application.Interfaces.Repositories;
using Core.Application.Sitemaps.Queries;
using Infrastructure.Data;
using Infrastructure.Data.Repositories;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models; // Add this for Swagger

var builder = WebApplication.CreateBuilder(args);
// Manually set the HTTPS port
builder.WebHost.ConfigureKestrel(options =>
{
    options.ListenLocalhost(5146); // HTTP port
    options.ListenLocalhost(44337, listenOptions => listenOptions.UseHttps()); // HTTPS port
});
// Add services to the container.
var configuration = builder.Configuration;

// Configure MySQL Database
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseMySql(configuration.GetConnectionString("DefaultConnection"),
    ServerVersion.AutoDetect(configuration.GetConnectionString("DefaultConnection"))));

// Configure JWT Authentication
var jwtSettings = configuration.GetSection("Jwt");
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
        ValidateIssuerSigningKey = true,
        ValidIssuer = jwtSettings["Issuer"],
        ValidAudience = jwtSettings["Audience"],
        IssuerSigningKey = new SymmetricSecurityKey(key)
    };
});

// Register the Sitemap services and repositories
builder.Services.AddScoped<ISitemapRepository, SitemapRepository>();
builder.Services.AddScoped<GetSitemapQuery>();

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

builder.Services.AddControllers();

var app = builder.Build();

// Enable Swagger middleware
app.UseSwaggerConfiguration();

if (!app.Environment.IsDevelopment())
{
    app.UseHttpsRedirection();  // Only use HTTPS redirection in non-development environments
}


// Middleware to use CORS
app.UseCors("AllowAll");

// Middleware to use Authentication and Authorization
app.UseAuthentication();
app.UseAuthorization();

// Map controllers to endpoints
app.MapControllers();

app.Run();

// Swagger Configuration Extension
public static class SwaggerExtensions
{
    public static IApplicationBuilder UseSwaggerConfiguration(this IApplicationBuilder app)
    {
        app.UseSwagger();
        app.UseSwaggerUI(c =>
        {
            c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
        });

        return app;
    }
}
