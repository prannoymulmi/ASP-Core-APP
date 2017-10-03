using System.Threading.Tasks;
using App.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    public class Inside : Controller
    {
        private readonly SignInManager<ApplicationUser> _signInManager;

        public Inside(SignInManager<ApplicationUser> signInManager)
        {
            _signInManager = signInManager;    
        }
        // GET
        public IActionResult Index()
        {
           
            return View();
        }
        
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(int a)
        {
            await _signInManager.SignOutAsync();


            return RedirectToAction("Index", "Main");
        }
    }
}