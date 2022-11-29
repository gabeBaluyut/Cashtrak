using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using CashTrak.Models;

/// <summary>
/// Startup File
/// Starts the application
/// 
/// Author: Justin Payne, Gabriel Baluyut, Jason Cheung
/// Date: Nov 28 2022
/// Sources: https://www.figma.com/file/DklarVtdbhQRWyCkWTdjOq/CashTrak-Interface-Design?node-id=0%3A1 
/// Sources: https://getbootstrap.com/docs/4.1/components/modal/ 
/// Sources: https://getbootstrap.com/docs/5.0/components/accordion/ 
/// Sources: https://bootsnipp.com/snippets/AlZ7g 
/// Sources: https://learn.microsoft.com/en-us/dotnet/api/system.datetime.-ctor?view=net-7.0 
/// Sources: https://www.c-sharpcorner.com/blogs/date-and-time-format-in-c-sharp-programming1 
/// Sources: https://www.w3schools.com/html/html_form_elements.asp
/// Sources: https://www.youtube.com/watch?v=VF6wlRshzDQ
/// Sources: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/enum 
/// Sources: Lab 4 Implement a Code First ASP Core MVC Application
/// Sources: Lab 5 Understanding Controllers and Routing in ASP.NET Core MVC Applications
/// Sources: Lab 6 Authorization & Authentication
/// </summary>
namespace CashTrak
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
            services.AddDbContext<CashRequestDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));

            // original solution to authentication / identity
            //services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
            //    .AddEntityFrameworkStores<CashRequestDbContext>();

            services.AddIdentity<IdentityUser, IdentityRole>(options =>
            {
                options.Password.RequiredLength = 8;
                options.Password.RequireNonAlphanumeric = true;
                options.Password.RequireDigit = true;
            }).AddEntityFrameworkStores<CashRequestDbContext>().AddDefaultTokenProviders();

            services.AddControllersWithViews();
            services.AddRazorPages();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            // instruction that marks where the routing decisions are made
            app.UseRouting();

            // what are the credentials of this user?
            app.UseAuthentication();

            // based on credentials, is this user allowed to view the page?
            app.UseAuthorization();

            // instruction that configures what code runs after routing decisions
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Account}/{action=LogIn}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
