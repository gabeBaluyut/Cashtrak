using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Linq;
using CashTrak.Models;


/// <summary>
/// Account Controller
/// Handles all functionality to do with navigating through the main pages
/// 
/// Author: Justin Payne, Gabriel Baluyut, Jason Cheung
/// Date: Nov 11 2026
/// Sources: Lab 4 MovieStore
/// Sources: Lab 5 Routing & Controllers
/// Sources: Lab 6 Authorization & Authentication
/// </summary>
namespace CashTrak.Controllers
{
    public class HomeController : Controller
    {


        private CashRequestDbContext MyContext { get; set; }

        public HomeController(CashRequestDbContext context)
        {
            MyContext = context;
        }


        /// <summary>
        /// Sends the user to the index page with a list of cash requests
        /// </summary>
        public IActionResult Index()
        {
            var cashRequest = MyContext.CashRequests.OrderBy(c => c.Recipent).ToList();

            return View(cashRequest);
        }

        /// <summary>
        /// Sends the user to the profile page with a list of cash requests
        /// </summary>
        public IActionResult Profile()
        {
            var cashRequest = MyContext.CashRequests.OrderBy(c => c.Recipent).ToList();
            
            return View(cashRequest);
        }

        /// <summary>
        /// Sends the user to the friends page
        /// </summary>
        public IActionResult Friends()
        {
            return View();
        }

        /// <summary>
        /// Sends the user to the notification page
        /// </summary>
        public IActionResult Notifications()
        {
            var cashRequest = MyContext.CashRequests.OrderBy(c => c.Recipent).ToList();

            return View(cashRequest);
        }

        /// <summary>
        /// Sends the user to the error screen if there is any error present.
        /// </summary>
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
