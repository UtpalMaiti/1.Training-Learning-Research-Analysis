using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace PluralsightAuth.Client
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
            services.AddHttpClient();

            services.AddControllersWithViews();

            services.AddAuthentication(options =>
            {
                options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = OpenIdConnectDefaults.AuthenticationScheme;
            }).AddCookie(CookieAuthenticationDefaults.AuthenticationScheme)
             .AddOpenIdConnect(OpenIdConnectDefaults.AuthenticationScheme, options =>
             {
                 options.SignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                 options.Authority = "https://pluralsightb2cdemo.b2clogin.com/pluralsightb2cdemo.onmicrosoft.com/B2C_1_pluralsightb2cdemo/v2.0/";
                 options.ClientId = "d1629430-c3d4-4477-8b49-99dc9633975d";
                 options.ResponseType = "code";
                 options.SaveTokens = true;
                 options.Scope.Add("d1629430-c3d4-4477-8b49-99dc9633975d");
                 options.ClientSecret = "aENgsnr7l9Wtq-6.pJx.BttI5f_16.zPU6";
             });

            //.AddOpenIdConnect(OpenIdConnectDefaults.AuthenticationScheme, options =>
            //{
            //    options.SignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            //    options.Authority = "https://login.microsoftonline.com/32f61fed-c327-4305-b36d-3bc644e00a1b/v2.0";
            //    options.ClientId = "fceef681-1997-478a-8d91-1cfe82d978f1";
            //    options.ClientSecret = "xMSj.985xgpH.XJELO97EzdOI5i~9-Qq4W";
            //    options.ResponseType = "code";
            //    options.Scope.Add("api://e2bf5851-7bbc-49eb-9dd7-8fd813d83d40/FullAccess");
            //    options.SaveTokens = true;
            //});

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

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
