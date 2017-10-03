using Microsoft.AspNetCore.Mvc;

namespace App.ViewComponent
{
    public class RegisterUserViewComponent : Microsoft.AspNetCore.Mvc.ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}