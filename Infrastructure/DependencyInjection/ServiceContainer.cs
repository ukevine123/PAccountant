using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Infrastructure.Data;
using Application.Interfaces;
using Infrastructure.Repositories;

namespace Infrastructure.DependencyInjection
{
    public static class ServiceContainer
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            // Register ApplicationDbContext (service here) with SQL Server provider
            services.AddDbContext<ApplicationDbContext>(options =>
             options.UseSqlServer(configuration.GetConnectionString("PAccountantSQLConnection")), ServiceLifetime.Scoped);
            
            services.AddScoped<IAsset, AssetRepository>();

            return services;
        }
    }
}
