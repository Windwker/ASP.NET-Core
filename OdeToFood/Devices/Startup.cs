using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevicesManager.Data;
using DevicesManager.Models;
using DevicesManager.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DevicesManager
{
    public class Startup

        
    {
        private IConfiguration _configuration;

        public Startup(IConfiguration conf)
        {
            _configuration = conf;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddSingleton<Devices>();
            services.AddScoped<IDevicesData, SqlDevicesData>();
            services.AddDbContext<DevicesDbContext>(options => options.UseSqlServer(_configuration.GetConnectionString("DefaultConnection")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, IConfiguration conf)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc(configureRoutes);

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
        }

        private void configureRoutes(IRouteBuilder obj)
        {
            obj.MapRoute("default","{controller=home}/{action=index}/{id?}");
        }
    }
}
