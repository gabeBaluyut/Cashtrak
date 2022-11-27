using Microsoft.AspNetCore.Mvc;
using System;
using CashTrak.Models;
using System.Linq;
using Microsoft.AspNetCore.Identity;

/// <summary>
/// Functionality Controller
/// Handles all functionality to do with Adding cash requests and their process of completion
/// 
/// Author: Justin Payne, Gabriel Baluyut, Jason Cheung
/// Date: Nov 11 2026
/// Sources: Lab 4 MovieStore
/// Sources: Lab 5 Routing & Controllers
/// Sources: Lab 6 Authorization & Authentication
/// </summary>
namespace CashTrak.Controllers
{
    public class FunctionalityController : Controller
    {
        // Auth fields
        private SignInManager<IdentityUser> SignInManager;
        private UserManager<IdentityUser> UserManager;

        // Database Context
        private CashRequestDbContext MyContext { get; set; }

        public FunctionalityController(CashRequestDbContext context)
        {
            MyContext = context;
        }
        
        /// <summary>
        /// Sends a brand new empty CashRequest object to the add view
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Create()
        {
            var users = MyContext.Users.OrderBy(c => c.UserName).ToList();
            ViewBag.Users = users;
            return View("Add", new CashRequest());
        }

        /// <summary>
        /// Creates a cash request and sets the inital state to the Created state
        /// </summary>
        /// <param name="cashRequest">CashRequest: a newly created cash request </param>
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

        /// <summary>
        /// Changes a cash request in the database from the Created state to Accepted State
        /// </summary>
        /// <param name="id">Int: Cash request id number to find request in DB</param>
        public IActionResult Accept(int id)
        {
            var cashRequest = MyContext.CashRequests.Find(id);
            if (cashRequest != null)
            {
                cashRequest.State = "Accepted";
                MyContext.CashRequests.Update(cashRequest);
                MyContext.SaveChanges();
            }
            return RedirectToAction("index", "home");

        }

        /// <summary>
        /// Changes a cash request in the database from the Accepted state to Sent state
        /// </summary>
        /// <param name="id">Int: Cash request id number to find request in DB</param>
        public IActionResult Send(int id)
        {
            var cashRequest = MyContext.CashRequests.Find(id);
            if (cashRequest != null)
            {
                cashRequest.State = "Sent";
                cashRequest.CompletionRequestUser = User.Identity.Name;
                MyContext.CashRequests.Update(cashRequest);
                MyContext.SaveChanges();
            }
            return RedirectToAction("index", "home");

        }

        /// <summary>
        /// Changes a cash request in the database from the Sent state to the Complete State
        /// </summary>
        /// <param name="id">Int: Cash request id number to find request in DB</param>
        public IActionResult Complete(int id)
        {
            var cashRequest = MyContext.CashRequests.Find(id);
            if (cashRequest != null)
            {
                cashRequest.State = "Complete";
                MyContext.CashRequests.Update(cashRequest);
                MyContext.SaveChanges();
            }
            return RedirectToAction("index", "home");

        }
    }
}
