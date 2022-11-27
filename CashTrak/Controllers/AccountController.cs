using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using CashTrak.Models;

/// <summary>
/// Account Controller
/// Handles all functionality to do with Authentication & Authorization
/// 
/// Author: Justin Payne, Gabriel Baluyut, Jason Cheung
/// Date: Nov 11 2026
/// Sources: Lab 4 MovieStore
/// Sources: Lab 5 Routing & Controllers
/// Sources: Lab 6 Authorization & Authentication
/// </summary>
namespace CashTrak.Controllers
{
    public class AccountController : Controller
    {
        // Auth Fields
        private UserManager<IdentityUser> userManager;
        private SignInManager<IdentityUser> signInManager;

        public AccountController(UserManager<IdentityUser> userMngr,
            SignInManager<IdentityUser> signInMngr)
        {
            userManager = userMngr;
            signInManager = signInMngr;
        }

        /// <summary>
        /// Sends user to the Register view
        /// </summary>
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        /// <summary>
        /// Registers a new account
        /// </summary>
        /// <param name="model">RegisterViewModel: model representing a user object</param>
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new User { UserName = model.Username };
                var result = await userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    bool isPersistent = false;
                    await signInManager.SignInAsync(user, isPersistent);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            return View(model);
        }

        /// <summary>
        /// Logout Functionality, signs the user out of the application.
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Login", "Account");
        }

        /// <summary>
        /// Sends the user to the login page
        /// </summary>
        /// <param name="returnURL">String: return URL of where to return too</param>
        [HttpGet]
        public IActionResult LogIn(string returnURL = "")
        {
            var model = new LoginViewModel { ReturnUrl = returnURL };
            return View(model);
        }

        /// <summary>
        /// Login Functionality, Logs a user into the application
        /// </summary>
        /// <param name="model">LoginViewModel: Model representing a user logging in</param>
        [HttpPost]
        public async Task<IActionResult> LogIn(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await signInManager.PasswordSignInAsync(
                    model.Username, model.Password, isPersistent: model.RememberMe,
                    lockoutOnFailure: false);

                if (result.Succeeded)
                {
                    if (!string.IsNullOrEmpty(model.ReturnUrl) &&
                        Url.IsLocalUrl(model.ReturnUrl))
                    { return Redirect(model.ReturnUrl); }
                    else
                    { return RedirectToAction("Index", "Home"); }
                }
            }
            ModelState.AddModelError("", "Invalid username/password.");
            return View(model);
        }

        /// <summary>
        /// Redirects user to AccessDenied view
        /// </summary>
        public ViewResult AccessDenied()
        {
            return View();
        }
    }

}
