using FastGallery.Application.Interfaces.Authentication;
using FastGallery.Application.Interfaces.Persistence;
using FastGallery.Infrastructure.Authentication;
using FastGallery.Infrastructure.Persistence;
using Microsoft.Extensions.DependencyInjection;

namespace FastGallery.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
        services.AddSingleton<IUserRepository, UserRepository>();
        return services;
    }
}