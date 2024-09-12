using LMS.Application;
using LMS.Core;
using LMS.Infrastructure;

namespace LMS.Api;
public static class DependencyInjection
{
    public static IServiceCollection AddAppDI(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddCors();
        services.AddApplicationDI()
                .AddInfrastructureDI(configuration)
                .AddCoreDI();
        return services;
    }
}
