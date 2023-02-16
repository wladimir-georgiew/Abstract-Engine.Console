using AbstractEngine.Animals;
using AbstractEngine.Animals.Abstraction;
using AbstractEngine.Contracts;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace AbstractEngine
{
    public static class Program
    {
        static void Main()
        {
            var host = Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    // Easily replacable Animal implementation, without the need to modify the Engine class
                    services.AddTransient<IAnimal, Cat>();
                    services.AddTransient<IEngine, AnimalEngine>();
                })
                .Build();

            var engine = ActivatorUtilities.CreateInstance<AnimalEngine>(host.Services);
            engine.Run();
        }
    }
}