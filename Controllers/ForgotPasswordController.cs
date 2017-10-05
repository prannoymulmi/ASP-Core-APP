using System.Threading.Tasks;
using App.Models;
using App.ViewModels;
using CourseProjectApp.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    public class ForgotPasswordController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;

        private readonly IEmailSend _emailSend;

        public ForgotPasswordController(UserManager<ApplicationUser> userManager, IEmailSend emailSend)
        {
            _emailSend = emailSend;
            _userManager = userManager;
        }
        
        // GET
        public IActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(ForgotPasswordViewModel model)
        {
            
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync(model.Email);
                var confirmed = await _userManager.IsEmailConfirmedAsync(user);
                if (user == null || !confirmed)
                {

                    return RedirectToAction("Index", "Main");
                }
                // Send Email Confirmation

                var code = await _userManager.GeneratePasswordResetTokenAsync(user);
                var callbackUrl = Url.Action("Index", "ResetPassword", new { userId = user.Id, code = code },
                    protocol: HttpContext.Request.Scheme);
                await
                    _emailSend.SendEmailAsync(model.Email, "Reset Password",
                        $"Please Reset you Password by " +
                        $"clicking this link:<a href='{callbackUrl}'>Link</a>");


            }

            return View(model);
        }
    }
}