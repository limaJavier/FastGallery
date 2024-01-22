using FastGallery.Application.Interfaces.Authentication;
using FastGallery.Application.Interfaces.Persistence;
using FastGallery.Infrastructure.Authentication;
using FastGallery.Infrastructure.Persistence;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FastGallery.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfigurationManager configuration)
    {
        services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
        services.Configure<JwtSettings>(configuration.GetSection(JwtSettings.SECTION_NAME));
        services.AddSingleton<IUserRepository, UserRepository>();
        return services;
    }
}