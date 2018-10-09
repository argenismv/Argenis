/*
 * Change History
 * -- Date -- Developer -- Description
 * 
 * 2018 October 2 - argenismv - Creation of project
 * 2018 October 3 - argenismv - Modification of services to add MVC
 * 2018 October 8 - argenismv - Created the folder Models and Pie Class
 * 2018 October 9 - argenismv - Created properties in Pie Class, IPieRepository, MockPieRepository
 * 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace BethanysPieShop
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(); // This line adds and enables MVC into the application
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            // The sequence in which the pipeline is added is important

            app.UseDeveloperExceptionPage(); // Added to default application for feedback when something goes wrong
            app.UseStatusCodePages(); // Middleware component that shows status of the request
            app.UseStaticFiles(); // Search in the wwwroot folder static files like css or images
            app.UseMvcWithDefaultRoute(); // Adds default routing to MVC, should be placed after UseStaticFiles
        }
    }
}
