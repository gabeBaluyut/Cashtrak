using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CashTrak.Models;

namespace CashTrak.Controllers
{
    public class HomeController : Controller
    {


        private CashRequestDbContext MyContext { get; set; }

        public HomeController(CashRequestDbContext context)
        {
            MyContext = context;
        }

        public IActionResult Index()
        {
            var cashRequest = MyContext.CashRequests.OrderBy(c => c.Recipent).ToList();
            return View(cashRequest);
        }

        public IActionResult Profile()
        {
            return View();
        }

        public IActionResult Friends()
        {
            return View();
        }

        public IActionResult Notifications()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
