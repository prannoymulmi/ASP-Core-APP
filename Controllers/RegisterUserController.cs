using System;
using System.Threading.Tasks;
using App.Models;
using App.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    public class RegisterUserController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public RegisterUserController(UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;

        }

        // GET
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(RegisterUserViewModel model)
        {
            
            if (ModelState.IsValid)
            {
                var identityUser = new ApplicationUser
                {
                    UserName = model.Username,
                    Email = model.Username

                };
                var signUpSucces = await _userManager.CreateAsync(identityUser, model.Password);
                if (signUpSucces.Succeeded)
                {
                    await _signInManager.SignInAsync(identityUser, isPersistent: false);
                    RedirectToAction("Index", "Inside");
                }
                else
                {
                    String error = "";
                    foreach (var err in signUpSucces.Errors)
                    {
                        error += err.Description + " ";
                    }

                    ModelState.AddModelError(string.Empty, "Error in Creating user" + " " + error);
                    return View(model);
                }
            }
            return  View(model);
        }
    }
}