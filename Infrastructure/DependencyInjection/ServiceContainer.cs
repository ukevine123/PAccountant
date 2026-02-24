using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using Infrastructure.Data;
using Application.Interface;
using Application.Service.Liabilities;
using Infrastructure.Repositories;

using Domain.Entities;


namespace Infrastructure.DependencyInjection
{
    public static class ServiceContainer
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            // add infrastructure services here, e.g., DbContext
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")), ServiceLifetime.Scoped
                );
 
                // Register repositories
                services.AddScoped<ILiability, LiabilityRepository>();
                
                // Register application services
                services.AddScoped<ILiabilityService, LiabilityService>();
                
                // services.AddScoped<ICampaign, CampaignRepository>();
                //  services.AddScoped<ISupportTicket, SupportTicketRepository>();
                //  services.AddScoped<IIdentity, IdentityRepository>();

                //  //Regester identity service
                //  services.AddAuthenticationService(configuration);
               

            // Register other infrastructure services here

            return services;
        }
    }
}
