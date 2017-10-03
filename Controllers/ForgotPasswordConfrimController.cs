using App.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    public class ForgotPasswordConfrimController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(ForgotPasswordConfirmViewModel model)
        {
            
            return RedirectToAction("Index", "Main");
        }
    }
}