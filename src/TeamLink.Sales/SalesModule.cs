using Microsoft.Extensions.DependencyInjection;
using TeamLink.Infrastructure;

namespace TeamLink.Sales;

public class SalesModule : IModule
{
    public string Name => "Sales";

    public void OnStart()
    {
        Console.WriteLine("Module started");
    }

    public void RegisterServices(IServiceCollection serviceCollection)
    {
        Console.WriteLine("Services registered");
    }

    public void OnStarted()
    {
        Console.WriteLine("Module started");
    }
}