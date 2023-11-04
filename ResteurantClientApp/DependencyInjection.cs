using Microsoft.Extensions.DependencyInjection;
using ResteurantClientApp.Containers;
using ResteurantClientApp.Services.Common;
using ResteurantClientApp.Services.Common.Interfaces;
using ResteurantClientApp.Services.Resteurant;

namespace ResteurantClientApp
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddMainFormServiceContainer(this IServiceCollection services)
        {
            services.AddSingleton<MainFormServicesContainer>();
            services.AddScoped<IRestClientService, RestClientService>();
            services.AddScoped<IResteurantService, ResteurantService>();
            return services;
        }
    }
}
