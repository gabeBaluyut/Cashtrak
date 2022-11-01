using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CashTrak.Models;

namespace CashTrak.Controllers
{
    public class FunctionalityController : Controller
    {

        private CashRequestDbContext MyContext { get; set; }

        public FunctionalityController(CashRequestDbContext context)
        {
            MyContext = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View("Add", new CashRequest());
        }

        [HttpPost]
        public IActionResult Create(CashRequest cashRequest)
        {
            if (ModelState.IsValid)
            {
                //Hardcoded User because no auth yet
                cashRequest.User = "Justin";
                cashRequest.CreationDate = System.DateTime.Now;
                cashRequest.Amount = Math.Round(cashRequest.Amount, 2);
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
