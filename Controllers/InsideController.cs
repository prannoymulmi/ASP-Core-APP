using System.Threading.Tasks;
using App.Models;
using App.Repository;
using App.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    public class Inside : Controller
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IUserDetailRepo _userRepo;

        public Inside(SignInManager<ApplicationUser> signInManager, IUserDetailRepo userRepo, UserManager<ApplicationUser> userManager)
        {
            _signInManager = signInManager;
            _userRepo = userRepo;
            _userManager = userManager;
        }
        // GET
        public IActionResult Index()
        {
            var userId = _userManager.GetUserId(HttpContext.User);
            var hobbies = _userRepo.GetHobbies(userId);

            var individual = _userRepo.GetIndividual(userId);

            var organization = _userRepo.GetOrganization(userId);

            var model = new InsideViewModel
            {
                Individuals = individual,
                Organizations = organization,
                Hobbies = hobbies

            };

            return View(model);
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