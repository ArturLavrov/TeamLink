using System.Reflection;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using TeamLink.Infrastructure;

namespace TeamLink.Bootstrapper
{
    public class ModuleLoader
    {
        public void LoadModules(WebApplicationBuilder builder)
        {
            foreach (var moduleAssembly in GetAssemblies())
            {
                var moduleClassType = moduleAssembly.GetTypes()
                    .Single(t => t.IsAssignableTo(typeof(IModule)));
                var moduleInstance = (IModule)Activator.CreateInstance(moduleClassType);
            
                moduleInstance.OnStart();
            
                moduleInstance.RegisterServices(builder.Services);
            
                builder.Services.AddControllers().PartManager.ApplicationParts.Add(new AssemblyPart(moduleAssembly));
                moduleInstance.OnStarted();
            }
        }


        private List<Assembly> GetAssemblies()
        {
            return new List<Assembly>(2)
            {
                Assembly.LoadFrom("/Users/artur/Projects/TeamLink/TeamLink.Delivery/bin/Debug/net6.0/TeamLink.Delivery.dll"),
                Assembly.LoadFrom("/Users/artur/Projects/TeamLink/TeamLink.Sales/bin/Debug/net6.0/TeamLink.Sales.dll"),
            };
        }
    }
}

