

using System.Threading.Tasks;
using App.Entities;
using App.Models;
using App.ViewModels;
using CourseProjectFinal.Entities;
using Microsoft.AspNetCore.Antiforgery;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    public class MainController: Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        //private ApplicationDbContext _myContext;
        public MainController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            //this._myContext = myContext;
        }

        
        public IActionResult Index()
        {
            //SeedData.Seed(_myContext);
            return View();
        }
        
        [HttpGet]
        [ValidateAntiForgeryToken]
        public IActionResult Test(int a)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index", "Inside");
            }
            
            return RedirectToAction("Index", "RegisterUser");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var loginResults =
                    await
                        _signInManager.PasswordSignInAsync(model.Username, model.Password, model.RememberMe,
                            lockoutOnFailure: false);
                if (loginResults.Succeeded)
                {
                    return RedirectToAction("Index", "Inside");

                } 
             
                ModelState.AddModelError(string.Empty, "Invalid Login Information.");
                return View(model);
            }
            return View(model);
        }
    }
}