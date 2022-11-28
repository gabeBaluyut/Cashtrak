using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CashTrak.Models;


/// <summary>
/// Account Controller
/// Handles all functionality to do with Editing Cash Requests
/// 
/// Author: Justin Payne, Gabriel Baluyut, Jason Cheung
/// Date: Nov 11 2026
/// Sources: Lab 4 MovieStore
/// Sources: Lab 5 Routing & Controllers
/// Sources: Lab 6 Authorization & Authentication
/// </summary>
namespace CashTrak.Controllers
{
    public class EditController : Controller
    {
        private CashRequestDbContext MyContext { get; set; }

        public EditController(CashRequestDbContext context)
        {
            MyContext = context;
        }

        /// <summary>
        /// Sends the user to the edit view
        /// </summary>
        /// <param name="id">Int: cashrequest id used to find the cashrequest to edit from the database</param>
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            var cashRequest = MyContext.CashRequests.Find(id);
            return View(cashRequest);
        }

        /// <summary>
        /// Updates the cash request in the database
        /// </summary>
        /// <param name="cashRequest">CashRequest: Newly updated cash request to save into database</param>
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
