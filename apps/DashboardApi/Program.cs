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

// CORS policy configuration
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowFrontend", builder =>
    {
        builder.WithOrigins("http://localhost:5173", "https://asafarim.com") // Allow dev and prod origins
               .AllowAnyMethod()
               .AllowAnyHeader()
               .AllowCredentials();
    });
});

builder.Services.AddControllers();
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

app.UseHttpsRedirection();
app.UseRouting();
app.UseCors("AllowFrontend");
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();
app.Run();
