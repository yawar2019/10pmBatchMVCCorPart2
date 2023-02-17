using DatafirstApproachExampleInCore.Models;
using DatafirstApproachExampleInCore.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatafirstApproachExampleInCore
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddRazorPages();
            services.AddDbContext<EmployeeContext>(options => options.UseSqlServer(Configuration.GetConnectionString("SqlCon")));
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddTransient<MyMiddleware>();
            services.Configure<Students>(Configuration.GetSection("Students"));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();



            //app.Map("/tatabirla",builder=> { 
            //app.Use(async (context,next) => {
            //    await context.Response.WriteAsync("Middleware1 Request is Called <br/>");
            //    await next.Invoke();
            //    await context.Response.WriteAsync("Middleware1 Response is Called <br/>");

            //  });
            //});
            // app.UseMiddleware<MyMiddleware>();

            //app.MyMiddlewar3();
            //app.MapWhen(context => context.Request.Query.ContainsKey("EmpName"), builder =>
            //{
            //    builder.Run(async context =>
            //    {
            //        await context.Response.WriteAsync("EmpName is :"+context.Request.QueryString.Value[0]);
            //    });
            //});


            //app.Use(async (context, next) => {
                

            //    await context.Response.WriteAsync("Middleware2 Request is Called <br/>");
            //    await next.Invoke();
            //    await context.Response.WriteAsync("Middleware2 Response is Called <br/>");

 

            //});

            //app.Run(async context => {
            //    await context.Response.WriteAsync("Last Middleware is Called");
            //});
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                // Web projects mvc 
                //endpoints.MapControllerRoute(
                //    name: "Bakery",
                //    pattern: "Pizza/Bugger",//{controller}/{action}/{id?}"
                //    defaults: new { controller = "AboutUs", action = "index" }
                //    );



                //endpoints.MapControllerRoute(
                //    name: "default",
                //    pattern: "{controller=Home}/{action=Index}/{id?}");

                  endpoints.MapDefaultControllerRoute();
                //endpoints.MapControllers();//attributes routing and api
                endpoints.MapRazorPages();//razor pages cshtml,cshtml.cs

            });
        }
    }
}

//1)run,use,Map,MapGet,MapWhen,CustomMiddleware, flow of middle ware examples

public class MyMiddleware : IMiddleware
{
       public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            await context.Response.WriteAsync("More then Money time is Important");


        }
    
}


//
// Summary:
//     Extension methods for the StaticFileMiddleware
public static class MyMiddlewar2
{
     
    public static IApplicationBuilder MyMiddlewar3(this IApplicationBuilder app)
    {
        return app.UseMiddleware<MyMiddleware>();
    }
}