using App.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    public class ForgotPasswordController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(ForgotPasswordViewModel model)
        {
            
            return RedirectToAction("Index", "Main");
        }
    }
}