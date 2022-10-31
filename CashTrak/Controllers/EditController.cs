using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CashTrak.Models;

namespace CashTrak.Controllers
{
    public class EditController : Controller
    {
        private CashRequestDbContext MyContext { get; set; }

        public EditController(CashRequestDbContext context)
        {
            MyContext = context;
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            var cashRequest = MyContext.CashRequests.Find(id);
            return View(cashRequest);
        }

        [HttpPost]
        public IActionResult Edit(CashRequest cashRequest)
        {
            if (ModelState.IsValid)
            {
                if (cashRequest.CashRequestID == 0)
                {
                    MyContext.CashRequests.Add(cashRequest);
                }
                else
                {
                    MyContext.CashRequests.Update(cashRequest);
                }
                MyContext.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Action = (cashRequest.CashRequestID == 0) ? "Add" : "Edit";
                return View(cashRequest);
            }
        }
    }
}
