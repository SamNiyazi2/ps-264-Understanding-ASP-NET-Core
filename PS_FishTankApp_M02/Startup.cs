using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using PS_FishTankApp_M02.Options;
using PS_FishTankApp_M02.Services;

namespace PS_FishTankApp_M02
{
    public class Startup
    {
        // 01/16/2021 02:54 pm - SSN - [20210116-1432] - [003] - M03-08 - Application settings

        public IHostingEnvironment Env { get; }

        public Startup(IHostingEnvironment env)
        {
            Env = env;
        }


        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {

            // 01/16/2021 02:51 pm - SSN - [20210116-1432] - [002] - M03-08 - Application settings

            var configBuilder = new ConfigurationBuilder();

            configBuilder
                .AddJsonFile("AlertThresholds.json")
                .AddJsonFile($"AlertThresholds{Env.EnvironmentName}.json", optional: true);

            IConfigurationRoot config = configBuilder.Build();

            services.Configure<ThresholdOptions>(config);





            // 01/15/2021 06:29 am - SSN - [20210115-0605] - [004] - M02-06 - The startup class
            // services.AddSingleton<ISensorDataService, SensorDataService>();
            services.AddTransient<ISensorDataService, SensorDataService>();

            // 01/15/2021 12:47 pm - SSN - [20210115-1233] - [006] - M03-04 - Unified controllers
            // services.AddSingleton<IViewModelService, ViewModelService>();
            services.AddTransient<IViewModelService, ViewModelService>();


            // 01/15/2021 11:19 am - SSN - [20210115-1119] - [001] - M03-02 - Setting up MVC 6
            services.AddMvc();



            // 01/15/2021 10:46 pm - SSN - [20210115-1311] - [001] - M03-05 - Tag Helpers
            services.AddSingleton<IActionContextAccessor, ActionContextAccessor>();
            services.AddSingleton<IUrlHelper>(factory =>
            {
                var actionContext = factory.GetService<IActionContextAccessor>()
                                               .ActionContext;
                return new UrlHelper(actionContext);
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        // 01/15/2021 08:06 am - SSN - [20210115-0803] - [003] - M02-09 - Into the pipeline 
        // Inject loggerFactory
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {


            // 01/15/2021 12:01 pm - SSN - [20210115-1201] - [001] - M03-03 - Environment 
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }




            // 01/15/2021 11:20 am - SSN - [20210115-1119] - [002] - M03-02 - Setting up MVC 6


            #region [20210115-1119] - [002] removed
            // Not needed.  
            //       loggerFactory.AddConsole(minLevel: LogLevel.Information);

            //////var logger = loggerFactory.CreateLogger("ssn_info_20210115a");// Category



            //////if (env.IsDevelopment())
            //////{
            //////    app.UseDeveloperExceptionPage();
            //////}

            //////// 01/15/2021 08:04 am - SSN - [20210115-0803] - [002] - M02-09 - Into the pipeline 
            ////////app.Run(async (context) =>
            //////app.Use(async (context, next) =>
            //////{
            //////    logger.LogInformation("20210115-0811-a: Before next in first middleware;");

            //////    await context.Response.WriteAsync("Hello World!");
            //////    await next();

            //////    logger.LogInformation("20210115-0811-b: After next in first middleware;");

            //////});

            //////// 01/15/2021 08:03 am - SSN - [20210115-0803] - [001] - M02-09 - Into the pipeline 

            //////app.Run(async (context) =>
            //////{
            //////    logger.LogInformation("20210115-0811-c: Before next in second middleware;");
            //////    await context.Response.WriteAsync("Hello World again!");
            //////    logger.LogInformation("20210115-0811-d: After next in second middleware;");
            //////});

            #endregion [20210115-1119] - [002] removed


            //app.UseMvc( routes =>
            //{
            //    routes.MapRoute(
            //        name: "default",
            //        template: "{controller=home}/{action=index}/{id?}");
            //});

            // Same as 

            app.UseMvcWithDefaultRoute();
            app.UseStaticFiles(); // For serving images, css and JavaScript files.0

            app.UseStatusCodePages();
            // app.UseStatusCodePagesWithRedirects("~/error/code{0}");




        }
    }
}
