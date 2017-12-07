using System;
using System.Threading.Tasks;
using BigNumbersAdder.Controller;
using BigNumbersAdder.Services;
using Microsoft.Extensions.DependencyInjection;

namespace BigNumbersAdder
{
    class Program
    {
        static void Main(string[] args)
        {
            Task.Run(() => MainAsync(args)).Wait();
        }

        private static async Task MainAsync(string[] args)
        {
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);

            // create service provider
            var serviceProvider = serviceCollection.BuildServiceProvider();

            await serviceProvider.GetService<MainController>().Run(args);
        }

        private static void ConfigureServices(IServiceCollection serviceCollection)
        {
            // add services
            serviceCollection.AddTransient<IBigWholeNumberAdderService, BigWholeNumberAdderService>();

            // add app
            serviceCollection.AddTransient<MainController>();
        }
    }
}
