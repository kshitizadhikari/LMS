using LMS.Application.Services;
using LMS.Core.Services;
using Microsoft.Extensions.DependencyInjection;

namespace LMS.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationDI(this IServiceCollection services)
        {
            services.AddScoped<ICustomerService, CustomerService>();
            services.AddScoped<IServiceWrapper, ServiceWrapper>();
            return services;
        }
    }
}
