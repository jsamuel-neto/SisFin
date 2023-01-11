using SisFin.Data;
using Microsoft.Extensions.DependencyInjection;
using SisFin.Authorizer.Services;

namespace SisFin.WebApi.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<DataContext>();
            services.AddScoped<AccessManager>();
            
            //Repositories

            //Services
        }
    }
}