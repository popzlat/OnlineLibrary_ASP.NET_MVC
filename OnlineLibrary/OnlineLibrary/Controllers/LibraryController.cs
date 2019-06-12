using Microsoft.AspNetCore.Mvc;
using OnlineLibrary.Data;

namespace OnlineLibrary.Controllers
{
    public class LibraryController : Controller
    {
        private readonly ILibraryRepository  _libraryRepository;

        public LibraryController(ILibraryRepository libraryRepository)
        {
            
            _libraryRepository = libraryRepository;

        }


        public IActionResult Index()
        {
            ViewBag.Title = "Book overview";
            var books = _libraryRepository.GetBooks();

            return View(books);
        }
    }
}