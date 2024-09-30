using App.Application;
using App.Infrasttrcuture;

namespace App.API
{
    public static class DependencyInjection
    {
        public static IServiceCollection ApiServices(this IServiceCollection services)
        {
            services.ApplicationServices()
                     .InfrastructureServices();

            return services;
        }
    }
}
