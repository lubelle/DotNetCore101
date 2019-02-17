using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace EmployeeManagement
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        // CreateDefaultBuilder() performs setting up the web server,
        // loading the host and application configurations,
        // configuring logging
        // <AspNetCoreHostingModel>InProcess</AspNetCoreHostingModel>
        // CreateDefaultBuilder() method calls UseIIS() method and host the app
        // inside of the IIS worker process (w3wp.exe or iisexpress.exe)
        // InProcess hosting delivers significantly higher request throughput than OutOfProcess hosting
        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
