using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/// <summary>
/// Program File
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
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
