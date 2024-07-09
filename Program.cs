using System;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Proba.Data.Interfaces;
using Proba.Data.Mokcs;
using Microsoft.Extensions.Hosting;
using Proba.Data;
using Microsoft.EntityFrameworkCore;
using Proba.Data.Repository;

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
			private IConfigurationRoot root;

			public Startup(IWebHostEnvironment hosting)
			{
				root = new ConfigurationBuilder()
					.SetBasePath(hosting.ContentRootPath)
					.AddJsonFile("DBSettings.json", optional: false, reloadOnChange: true)
					.Build();
			}

			public void ConfigureServices(IServiceCollection services)
			{
				services.AddDbContext<AppDBContent>(options =>
					options.UseSqlServer(root.GetConnectionString("DefaultConnection")));

				//services.AddTransient<ICars, CarRepository>();
				//services.AddTransient<ICarsCategory, CategoryRepository>();
				services.AddTransient<ICars, MockCars>();
				services.AddTransient<ICarsCategory, MockCategory>();

				services.AddControllersWithViews(); 
			}

			public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
			{
				if (env.IsDevelopment())
				{
					app.UseDeveloperExceptionPage();
				}
				else
				{
					app.UseExceptionHandler("/Home/Error");
					app.UseHsts();
				}

				app.UseHttpsRedirection();
				app.UseStaticFiles();
				app.UseRouting();
				app.UseAuthorization();

				app.UseEndpoints(endpoints =>
				{
					endpoints.MapControllerRoute(
						name: "default",
						pattern: "{controller=Car}/{action=Result}/{id?}");
				});
			}
        }
    }
}