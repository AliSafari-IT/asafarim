using ASafariM.Application.Interfaces;
using ASafariM.Application.Mappings;
using ASafariM.Application.Services;
using ASafariM.Application.Utils;
using ASafariM.Domain.Entities;
using ASafariM.Domain.Interfaces;
using ASafariM.Infrastructure.Persistence;
using ASafariM.Infrastructure.Repositories;
using ASafariM.Infrastructure.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.DependencyInjection;
using Serilog;

namespace ASafariM.Api
{
    public static class ServiceRegistration
    {
        public static void RegisterServices(WebApplicationBuilder builder)
        {
            var services = builder.Services;
            Log.Information("Starting service registration...");

            // Register repositories
            RegisterRepositories(services);

            // Register services
            RegisterApplicationServices(services);

            // Register AutoMapper profiles
            RegisterAutoMapper(services);
        }

        private static void RegisterRepositories(IServiceCollection services)
        {
            services.AddScoped<CurrentUserService>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IPostRepository, PostRepository>();
            services.AddScoped<ITagRepository, TagRepository>();
            services.AddScoped<ITopicRepository, TopicRepository>();
            services.AddScoped<ISitemapItemRepository, SitemapItemRepository>();
            services.AddScoped<IBibliographyRepository, BibliographyRepository>();
        }

        private static void RegisterApplicationServices(IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IProjectService, ProjectService>();
            services.AddScoped<IEmailService, EmailService>();
            services.AddScoped<JwtTokenService>();
            services.AddScoped<GoogleAuthService>();
            services.AddScoped<IRoleService, RoleService>();
            services.AddScoped<ICurrentUserService, CurrentUserService>();
            services.AddScoped<IBibliographyService, BibliographyService>();

            // Register IEntityService<T>
            services.AddScoped(typeof(IEntityService<>), typeof(EntityService<>));

            // Register authorization & current user services
            services.AddScoped<
                ASafariM.Application.Interfaces.IAuthorizationService,
                ASafariM.Infrastructure.Services.AuthorizationService
            >();
        }

        private static void RegisterAutoMapper(IServiceCollection services)
        {
            services.AddAutoMapper(typeof(UserMappingProfile).Assembly);
        }
    }
}
