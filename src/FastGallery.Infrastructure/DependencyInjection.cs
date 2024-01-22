using FastGallery.Application.Interfaces.Authentication;
using FastGallery.Infrastructure.Authentication;
using Microsoft.Extensions.DependencyInjection;

namespace FastGallery.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
        return services;
    }
}