using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnlineLibrary.Services;

namespace OnlineLibrary.Controllers
{
    public class LoanController : Controller
    {
        private readonly ILibraryService _libraryservice;

        public LoanController(ILibraryService libraryservice)
        {
            _libraryservice = libraryservice;
        }


        public IActionResult LoanBook()
        {
            var library = _libraryservice.GetBooks();
            return View(library);
        }
        public IActionResult Quantity( int id)
        {
            var library = _libraryservice.GetById(id);
            return View(library);
        }

    }
}