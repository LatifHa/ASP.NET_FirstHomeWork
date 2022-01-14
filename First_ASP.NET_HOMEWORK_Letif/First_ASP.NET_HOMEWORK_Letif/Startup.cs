using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace First_ASP.NET_HOMEWORK_Letif
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
               

                endpoints.MapControllerRoute(
                    "default",
                    "{controller}/{action=index}"
                    );

                endpoints.MapControllerRoute(
                    "default2",
                    "{controller=home}/{action=index}"
                    );

                endpoints.MapControllerRoute(
                    "default3",
                    "what-we-do", //bu ad yazilarsa!
                    defaults: new { controller = "home", action = "about" } //bura kecid et!
                    );

                endpoints.MapControllerRoute(
                    "default4",
                    "elaqe", 
                    defaults: new { controller = "home", action = "contact" } 
                    );
            });
        }
    }
}
