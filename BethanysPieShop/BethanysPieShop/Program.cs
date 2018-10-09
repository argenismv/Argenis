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
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace BethanysPieShop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}
