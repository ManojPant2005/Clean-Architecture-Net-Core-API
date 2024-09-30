using Microsoft.Extensions.DependencyInjection;

namespace App.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection ApplicationServices(this IServiceCollection services)
        {
            return services;     
        }
    }
}
