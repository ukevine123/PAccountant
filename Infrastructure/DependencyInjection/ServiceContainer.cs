using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Infrastructure.Data;
using Application.Interface;
using Application.Interfaces;
using Application.Services.AccountService;
using Application.Service.Liabilities;
using Application.Services.Assets;
using Infrastructure.Repositories;

namespace Infrastructure.DependencyInjection
{
    public static class ServiceContainer
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            // Register ApplicationDbContext (service here) with SQL Server provider
            services.AddDbContext<ApplicationDbContext>(options =>
             options.UseSqlServer(configuration.GetConnectionString("PAccountantMSSQLConnection")), ServiceLifetime.Scoped);
            
            services.AddScoped<IAsset, AssetRepository>();
            services.AddScoped<ILiability, LiabilityRepository>();
            services.AddScoped<IAccount, AccountRepository>();
            services.AddScoped<ITransaction, TransactionRepository>();
            
            
            // Register Application Services
            services.AddScoped<IAssetService, AssetService>();
            services.AddScoped<ILiabilityService, LiabilityService>();
            services.AddScoped<IAccountService, AccountService>();

            return services;
        }
    }
}
