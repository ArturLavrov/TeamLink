using Microsoft.Extensions.DependencyInjection;
using TeamLink.Delivery.Services;
using TeamLink.Infrastructure;

namespace TeamLink.Delivery
{
    public class DeliveryModule : IModule
    {
        public string Name { get; } = "Delivery";
        
        public void OnStart()
        {
            Console.WriteLine("module started");
        }

        public void RegisterServices(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<ICargoTrackingService, CargoTrackingService>();
        }

        public void OnStarted()
        {
            //some stuff after module started
        }
    }
}

