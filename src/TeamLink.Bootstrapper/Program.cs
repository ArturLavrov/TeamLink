using Microsoft.OpenApi.Models;

namespace TeamLink.Bootstrapper
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            
            var moduleLoader = new ModuleLoader();
            moduleLoader.LoadModules(builder);
            
            //add swagger for all controllers
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("sales", new OpenApiInfo
                {
                    Title = "Sales module",
                    Version = "v1"
                });
                c.SwaggerDoc("delivery", new OpenApiInfo
                {
                    Title = "Delivery module",
                    Version = "v1"
                });
            });
            //build an app
            var app = builder.Build();

            //enable swagger for all modules in development mode
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/sales/swagger.json", "sales");
                    c.SwaggerEndpoint("/swagger/delivery/swagger.json", "delivery");
                });
            }
            app.UseHttpsRedirection();
            app.MapControllers();
            app.Run();
        }
    }
} 


 
