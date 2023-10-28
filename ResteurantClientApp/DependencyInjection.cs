using Microsoft.Extensions.DependencyInjection;
using ResteurantClientApp.Containers;
using ResteurantClientApp.Services;
using ResteurantClientApp.Services.Interfaces;

namespace ResteurantClientApp
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddMainFormServiceContainer(this IServiceCollection services)
        {
            services.AddScoped<MainFormServicesContainer>();
            services.AddScoped<IRestClientServices, RestClientServices>();
            return services;
        }
    }
}
