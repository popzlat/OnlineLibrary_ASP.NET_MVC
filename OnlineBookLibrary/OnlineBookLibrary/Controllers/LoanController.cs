using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnlineBookLibrary.BusinessLayer;

namespace OnlineBookLibrary.Controllers
{
    public class LoanController : Controller
    {
       

        public IActionResult LoanBook()
        {
            return View();
        }
    }
}