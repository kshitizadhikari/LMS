using LMS.Core.Interfaces;
using LMS.Infrastructure.Data;
using LMS.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace LMS.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureDI(this IServiceCollection services, IConfiguration configuration )
        {
            //services.AddDbContext<AppDbContext>(options =>
            //options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));
            services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<IFoodRepository, FoodRepository>();
            services.AddScoped<IMenuRepository, MenuRepository>();
            services.AddScoped<IMenuItemRepository, MenuItemRepository>();
            services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();
            return services;
        }
    }
}
