using Microsoft.AspNetCore.Mvc;

namespace App.ViewComponent
{
    public class LoginViewComponent: Microsoft.AspNetCore.Mvc.ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("Index");
        }
    }
}