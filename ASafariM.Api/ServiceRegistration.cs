using ASafariM.Application.Interfaces;
using ASafariM.Application.Mappings;
using ASafariM.Application.Services;
using ASafariM.Domain.Entities;
using ASafariM.Domain.Interfaces;
using ASafariM.Infrastructure.Persistence;
using ASafariM.Infrastructure.Repositories;
using ASafariM.Infrastructure.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Serilog;

namespace ASafariM.Api
{
    public static class ServiceRegistration
    {
        public static void RegisterServices(WebApplicationBuilder builder)
        {
            var services = builder.Services;

            Log.Information("Registering services...");

            // Register repositories
            services.AddScoped<IUserRepository, UserRepository>();
            Log.Information("Registered IUserRepository with UserRepository.");

            services.AddScoped<IGenericRepository<Role>, GenericRepository<Role>>();
            Log.Information("Registered IGenericRepository<Role> with GenericRepository<Role>.");

            services.AddScoped<IGenericRepository<User>, GenericRepository<User>>();
            Log.Information("Registered IGenericRepository<User> with GenericRepository<User>.");

            services.AddScoped<IGenericRepository<MarkdownFile>, GenericRepository<MarkdownFile>>();
            Log.Information(
                "Registered IGenericRepository<MarkdownFile> with GenericRepository<MarkdownFile>."
            );

            // Register new blog-related repositories
            services.AddScoped<IPostRepository, PostRepository>();
            Log.Information("Registered IPostRepository with PostRepository.");

            services.AddScoped<ITagRepository, TagRepository>();
            Log.Information("Registered ITagRepository with TagRepository.");

            services.AddScoped<ITopicRepository, TopicRepository>();
            Log.Information("Registered ITopicRepository with TopicRepository.");

            services.AddScoped<ISitemapItemRepository, SitemapItemRepository>();
            Log.Information("Registered ISitemapItemRepository with SitemapItemRepository.");

            // Register Project-related repositories and services
            services.AddScoped<IProjectRepository, ProjectRepository>();
            Log.Information("Registered IProjectRepository with ProjectRepository.");

            services.AddScoped<IProjectService, ProjectService>();
            Log.Information("Registered IProjectService with ProjectService.");

            // Register generic entity services
            services.AddScoped(typeof(IEntityService<>), typeof(EntityService<>));
            Log.Information("Registered IEntityService<T> with EntityService<T>.");

            // email service
            services.AddScoped<IEmailService, EmailService>();
            Log.Information("Registered IEmailService with EmailService.");

            // Register services
            services.AddScoped<RoleService>();
            Log.Information("Registered RoleService.");

            services.AddScoped<IUserService, UserService>();
            Log.Information("Registered IUserService with UserService.");

            services.AddScoped<IMarkdownFilesService, MarkdownFilesService>();
            Log.Information("Registered IMarkdownFilesService with MarkdownFilesService.");

            services.AddScoped<JwtTokenService>();
            Log.Information("Registered JwtTokenService.");

            // Register AutoMapper profiles
            services.AddAutoMapper(typeof(UserMappingProfile).Assembly);
            Log.Information("Registered AutoMapper profiles.");
        }
    }
}
