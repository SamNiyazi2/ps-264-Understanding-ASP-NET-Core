using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using PS_FishTankApp_M02.Services;

namespace PS_FishTankApp_M02
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {

            // 01/15/2021 06:29 am - SSN - [20210115-0605] - [004] - M02-06 - The startup class
            services.AddSingleton<ISensorDataService, SensorDataService>();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        // 01/15/2021 08:06 am - SSN - [20210115-0803] - [003] - M02-09 - Into the pipeline 
        // Inject loggerFactory
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            // Not needed.  
            //       loggerFactory.AddConsole(minLevel: LogLevel.Information);

            var logger = loggerFactory.CreateLogger("ssn_info_20210115a");// Category



            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // 01/15/2021 08:04 am - SSN - [20210115-0803] - [002] - M02-09 - Into the pipeline 
            //app.Run(async (context) =>
            app.Use(async (context, next) =>
            {
                logger.LogInformation("20210115-0811-a: Before next in first middleware;");

                await context.Response.WriteAsync("Hello World!");
                await next();

                logger.LogInformation("20210115-0811-b: After next in first middleware;");

            });

            // 01/15/2021 08:03 am - SSN - [20210115-0803] - [001] - M02-09 - Into the pipeline 

            app.Run(async (context) =>
            {
                logger.LogInformation("20210115-0811-c: Before next in second middleware;");
                await context.Response.WriteAsync("Hello World again!");
                logger.LogInformation("20210115-0811-d: After next in second middleware;");
            });

        }
    }
}
