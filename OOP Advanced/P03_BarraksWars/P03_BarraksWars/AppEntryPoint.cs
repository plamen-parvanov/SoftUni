namespace _03BarracksFactory
{
    using System;

    using Contracts;
    using Core;
    using Core.Factories;
    using Data;
    using Microsoft.Extensions.DependencyInjection;

    class AppEntryPoint
    {
        static void Main(string[] args)
        {
            IServiceProvider serviceProvider = GenerateServices();

            ICommandFactory commandFactory = new CommandFactory(serviceProvider);

            ICommandInterpreter commandInterpreter = new CommandInterpreter(commandFactory);

            IRunnable engine = new Engine(commandInterpreter);

            engine.Run();
        }

        private static IServiceProvider GenerateServices()
        {
            var services = new ServiceCollection();

            services.AddSingleton<IRepository, UnitRepository>();
            services.AddTransient<IUnitFactory, UnitFactory>();

            return services.BuildServiceProvider();
        }
    }
}
