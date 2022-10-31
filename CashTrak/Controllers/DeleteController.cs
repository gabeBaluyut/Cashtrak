using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CashTrak.Models;

namespace CashTrak.Controllers
{
    public class DeleteController : Controller
    {
        private CashRequestDbContext MyContext { get; set; }

        public DeleteController(CashRequestDbContext context)
        {
            MyContext = context;
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var cashRequest = MyContext.CashRequests.Find(id);
            
            return View(cashRequest);
        }

        [HttpPost]
        public IActionResult Delete(CashRequest cashRequest)
        {
            MyContext.CashRequests.Remove(cashRequest);
            MyContext.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}
