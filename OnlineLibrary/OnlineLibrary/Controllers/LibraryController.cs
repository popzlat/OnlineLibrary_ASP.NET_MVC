using Microsoft.AspNetCore.Mvc;
using OnlineLibrary.Data;
using OnlineLibrary.Models;
using OnlineLibrary.Services;
using OnlineLibrary.ViewModels;

namespace OnlineLibrary.Controllers
{
    public class LibraryController : Controller
    {
        private readonly ILibraryService _libraryservice;

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

        public IActionResult Create()
        {
            var book = new BookViewModel();
            return View(book);
        }


        [HttpPost]
        public IActionResult Create(BookViewModel book)
        {
            if (!ModelState.IsValid)
            {
                return View(book);
            }

            _libraryservice.Create(book);
            return RedirectToAction("OnlineLibrary", "Library");
        }

        public IActionResult Details(int id)
        {
            ViewBag.Title = "Book overview";
            Library library = _libraryservice.GetBooks();
            return View(library);
        }

        public IActionResult Edit(int id)
        {
            return View();
        }

        public IActionResult Delete (int id)
        {
            return View();
        }
    }
}