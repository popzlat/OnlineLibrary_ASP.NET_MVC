﻿using Microsoft.AspNetCore.Mvc;

namespace OnlineLibrary.Controllers
{
    public class LibraryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}