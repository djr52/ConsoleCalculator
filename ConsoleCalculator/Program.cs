using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using ConsoleEventHandler;
namespace ConsoleCalculator
{
    public class Program
    {

        static void Main(string[] args)
        {
            ConsoleManager console = new ConsoleManager();
            var _serviceCollection = new ServiceCollection();
            ConfigureServices(_serviceCollection);

            var _serviceProvider = _serviceCollection.BuildServiceProvider();
            var _consoleEManager = _serviceProvider.GetService<ConsoleEventManager>();
           
            console.Start();

        }

        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddLogging(configure => configure.AddConsole())
                .AddTransient<ConsoleEventManager>();
        }


    }

}
