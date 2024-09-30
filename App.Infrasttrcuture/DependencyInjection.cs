using Microsoft.Extensions.DependencyInjection;

namespace App.Infrasttrcuture
{
    public static class DependencyInjection
    {
        public static IServiceCollection InfrastructureServices(this IServiceCollection services)
        {
            return services;     
        }
    }
}
