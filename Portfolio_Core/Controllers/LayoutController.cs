﻿using Microsoft.AspNetCore.Mvc;

namespace Portfolio_Core.Controllers
{
    public class LayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
