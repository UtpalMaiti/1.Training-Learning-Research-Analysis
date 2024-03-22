using _99.CoreBasics.Data;
using _99.CoreBasics.Utility;

using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

using System.Collections.Generic;

namespace _99.CoreBasics
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var levelOverride = new Dictionary<string, LogLevel>();
            //levelOverride.Add("Default", LogLevel.Information);
            //levelOverride.Add("Microsoft.AspNetCore", LogLevel.Debug);
            //levelOverride.Add("Microsoft", LogLevel.Warning);

                 builder.Logging.AddFile("Logs/myapp-{Date}.txt",
                LogLevel.Trace,
                levelOverride,false,null,null, 
                "{Timestamp:o} {RequestId,13} [{Level:u3}] {Message} ({EventId:x8}){NewLine}{Exception}");

            // Add services to the container.
            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(connectionString));
            builder.Services.AddDatabaseDeveloperPageExceptionFilter();

            builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ApplicationDbContext>();
            //builder.Services.AddMvc();
            //builder.Services.AddMvcCore();
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            app.UseMiddleware<ExceptionMiddleware>();

            app.UseExceptionHandler("/Home/Error");

            // Configure the HTTP request pipeline.
            //if (app.Environment.IsDevelopment())
            //{
            //    app.UseMigrationsEndPoint();
            //}
            //else
            //{
            //    app.UseExceptionHandler("/Home/Error");
            //    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            //    app.UseHsts();
            //}

            //app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
            app.MapRazorPages();

            app.Run();
        }
    }
}
