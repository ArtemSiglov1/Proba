using System;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Proba.Data.Interfaces;
using Proba.Data.Mokcs;

namespace Proba
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            CreateWedHost(args).Build().Run();
        }
        public static IWebHostBuilder CreateWedHost(string[] args) => WebHost.CreateDefaultBuilder(args)
            .UseStartup<Startup>();

        public class Startup
        {
            public void ConfigureServices(IServiceCollection services)
            {
                services.AddTransient<ICars,MockCars>();
                services.AddTransient<ICarsCategory, MockCategory>();
                services.AddMvc(); 
            }

            public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
            {
                if (env.IsDevelopment())
                {
                    app.UseDeveloperExceptionPage();
                }
                app.UseStatusCodePages();
                app.UseStaticFiles();
				app.UseRouting();
                
				app.UseEndpoints(endpoints =>
				{
					endpoints.MapControllerRoute(
						name: "default",
						pattern: "{controller=Home}/{action=Index}/{id?}");
				});
			}
        }
    }
}