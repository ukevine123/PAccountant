using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Infrastructure.Repositories;
using Application.Interfaces;
using Application.Services.Budgets;
using Infrastructure.Data;

namespace Infrastructure.DependencyInjection
{
    public static class ServiceContainer
    {
        public static IServiceCollection AddInfrastructureService(this IServiceCollection services, IConfiguration configuration)
{
    services.AddDbContext<ApplicationDbContext>(options =>
        options.UseSqlServer(configuration.GetConnectionString("PAccountantMSSQLConnection")));

    // Register Repositories
    services.AddScoped<IBudget, BudgetRepository>();

    return services; // <--- ADD THIS LINE HERE
}
    }
}