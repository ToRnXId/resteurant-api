using ResteurantApiAspNetCore2.Repositories;
using ResteurantApiAspNetCore2.Repositories.Interfaces;
using ResteurantApiAspNetCore2.Services;
using ResteurantApiAspNetCore2.Services.Interfaces;

namespace ResteurantApiAspNetCore2
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddSwaggerConfiguration(this IServiceCollection services)
        {
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();

            return services;
        }

        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IResteurantRepository, ResteurantRepository>();

            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IResteurantService, ResteurantService>();

            return services;
        }
    }
}
