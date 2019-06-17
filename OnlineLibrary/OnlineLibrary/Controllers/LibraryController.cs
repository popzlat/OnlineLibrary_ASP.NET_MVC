using Microsoft.AspNetCore.Mvc;
using OnlineLibrary.Data;
using OnlineLibrary.Models;
using OnlineLibrary.Services;
using OnlineLibrary.ViewModels;

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

        public IActionResult Create()
        {
            var book = new BookViewModel();
            return View(book);
        }

        
        //[HttpPost]
        //public IActionResult Create(PizzaViewModel pizza)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return View(pizza);
        //    }

        //    _pizzaService.CreatePizza(pizza);
        //    return RedirectToAction("Menu", "Pizza");
        //}
    }
}