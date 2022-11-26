using Microsoft.AspNetCore.Mvc;
using System;
using CashTrak.Models;
using System.Linq;
using System.Dynamic;
using Microsoft.AspNetCore.Identity;


namespace CashTrak.Controllers
{
    public class FunctionalityController : Controller
    {

        private SignInManager<IdentityUser> SignInManager;
        private UserManager<IdentityUser> UserManager;

        private CashRequestDbContext MyContext { get; set; }

        public FunctionalityController(CashRequestDbContext context)
        {
            MyContext = context;
        }
        

        [HttpGet]
        public IActionResult Create()
        {
            var users = MyContext.Users.OrderBy(c => c.UserName).ToList();
            ViewBag.Users = users;
            return View("Add", new CashRequest());
        }

        [HttpPost]
        public IActionResult Create(CashRequest cashRequest)
        {
            if (ModelState.IsValid)
            {
                cashRequest.User = User.Identity.Name;
                cashRequest.CreationDate = System.DateTime.Now;
                cashRequest.Amount = Math.Round(cashRequest.Amount, 2);
                cashRequest.State = "Created";
                MyContext.CashRequests.Add(cashRequest);
                MyContext.SaveChanges();
                return RedirectToAction("index", "home");
            }
            else
            {
                return RedirectToAction("index", "home");
            }
        }
    }
}
