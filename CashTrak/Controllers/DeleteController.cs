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

        public IActionResult Delete(int id)
        {           
            var cashRequest = MyContext.CashRequests.Find(id);
            if (cashRequest != null)
            {
                MyContext.CashRequests.Remove(cashRequest);
                MyContext.SaveChanges();
            }
            return RedirectToAction("Index", "Home");
        }
    }
}
