using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using OdeToFood.Services;

namespace OdeToFood
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IGreeter, Greeter>();
            services.AddScoped<IRestaurantData, InMemoryRestauranteData>();
            services.AddMvc();
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, IGreeter greeter, ILogger<Startup> logger)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
               //app.UseExceptionHandler();
            }
            //app.Use(next =>
            //{
            //    return async context =>
            //    {
            //        logger.LogInformation("Request Incomming");
            //        if (context.Request.Path.StartsWithSegments("/mym"))
            //        {
            //            await context.Response.WriteAsync("HIT!!!!!");
            //            logger.LogInformation("Request Handled");
            //        }
            //        else
            //        {
            //            await next(context);
            //            logger.LogInformation("Response Outgoing");
            //        }
            //    };
            //});
            //app.UseWelcomePage( new WelcomePageOptions {
            //Path = "/wp" });


            //app.UseDefaultFiles();//set default file to directory
            app.UseStaticFiles();//allow accessing files from wwwroot

            //app.UseMvcWithDefaultRoute(); // map the url to a class (Default)
            app.UseMvc(configureRoutes); // map the url to a class - method //  Conventional routing
            //app.UseMvc(); //Atribute routing. Needs to set [Route("[controller]/[action])] on class name.

            //app.UseFileServer(); //install a middleware for both UseDefaultFiles & UseStaticFiles 
            //app.UseWelcomePage(new WelcomePageOptions { Path = "/wp"});  // middleware for displaying a welcome page
            app.Run(async (context) =>
            {

                //               throw new Exception("ERROR!!");

                var greeting = greeter.GetMessageOfTheDay();
                context.Response.ContentType = "text/plain";
                await context.Response.WriteAsync("Not Found");
                //await context.Response.WriteAsync(greeting + env.EnvironmentName);
                
            });
        }

        // Conventional Route
        private void configureRoutes(IRouteBuilder routeBuilder)
        {
 //           routeBuilder.MapRoute("Default",  // Map
 //               "{controller}/{action}/{id?}");

            routeBuilder.MapRoute("Default",  // Map
                "{controller=Home}/{action=Index}/{id?}");
        }
    }
}
