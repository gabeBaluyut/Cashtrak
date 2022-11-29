using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CashTrak.Models;

/// <summary>
/// Account Controller
/// Handles all functionality to do with Deleting Cash Requests
/// 
/// Author: Justin Payne, Gabriel Baluyut, Jason Cheung
/// Date: Nov 11 2022
/// Sources: Lab 4 MovieStore
/// Sources: Lab 5 Routing & Controllers
/// Sources: Lab 6 Authorization & Authentication
/// </summary>
namespace CashTrak.Controllers
{
    public class DeleteController : Controller
    {
        private CashRequestDbContext MyContext { get; set; }

        public DeleteController(CashRequestDbContext context)
        {
            MyContext = context;
        }

        /// <summary>
        /// Deletes the cashrequest based on the id passed into the function
        /// </summary>
        /// <param name="id">Int: cashrequest id used to find the id in the database</param>
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
