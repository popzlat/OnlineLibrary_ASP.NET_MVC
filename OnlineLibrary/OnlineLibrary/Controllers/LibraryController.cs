using Microsoft.AspNetCore.Mvc;
using OnlineLibrary.Data;
using OnlineLibrary.Models;
using OnlineLibrary.Services;

namespace OnlineLibrary.Controllers
{
    public class LibraryController : Controller
    {
        private readonly ILibraryService  _libraryservice;

        public LibraryController(ILibraryService libraryservice)
        {
            _libraryservice = libraryservice;
        }


        public IActionResult OnlineLibrary()
        {
            ViewBag.Title = "Book overview";
            Library library = _libraryservice.GetBooks();
            return View(library);
        }
    }
}