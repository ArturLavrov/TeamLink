using Microsoft.Extensions.DependencyInjection;

namespace TeamLink.Infrastructure
{
    //interface is not ideal could be redesign but works well for demo purposes
    public interface IModule
    {
        public string Name { get; }

        public void OnStart();
        
        public void RegisterServices(IServiceCollection serviceCollection);
        
        public void OnStarted();
    }
}

