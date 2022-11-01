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
            MyContext.CashRequests.Add(cashRequest);
            MyContext.SaveChanges();
            return RedirectToAction("index", "home");
        }
    }
}
