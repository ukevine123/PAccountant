using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.DependencyInjection
{
    public static class AuthenticationServiceExtensions
    {
        public static IServiceCollection AddAuthenticationService(this IServiceCollection services, IConfiguration configuration)
        {
            // Placeholder: configure authentication/authorization here (JWT, cookies, etc.)
            // Example: services.AddAuthentication(...).AddJwtBearer(...);
            return services;
        }
    }
}
