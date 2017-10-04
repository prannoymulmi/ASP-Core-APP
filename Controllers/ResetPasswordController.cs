﻿using App.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    public class ResetPasswordController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(ResetPasswordViewModel model)
        {
            
            return RedirectToAction("Index", "Main");
        }
    }
}