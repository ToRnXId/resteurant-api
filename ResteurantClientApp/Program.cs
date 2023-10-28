using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ResteurantClientApp.Containers;
using ResteurantClientApp.Services.Interfaces;

namespace ResteurantClientApp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            HostApplicationBuilder builder = Host.CreateApplicationBuilder();
            builder.Services.AddMainFormServiceContainer();
            using IHost host = builder.Build();
            using IServiceScope serviceScope = host.Services.CreateScope();
            IServiceProvider provider = serviceScope.ServiceProvider;
            //provider.GetRequiredService<>;

            //var serviceProvider = new ServiceCollection()
            //    .AddServices()
            //    .BuildServiceProvider();
            //serviceProvider.CreateScope();

            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm(provider.GetRequiredService<MainFormServicesContainer>()));
        }
    }
}