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
            
            Book book = _libraryservice.GetById(id);
            return View(book);
        }
        


        public IActionResult Delete (int id)
        {
            Book book = _libraryservice.GetById(id);

            return View(book);
        }

        [HttpPost]
        public IActionResult Delete(Book book)
        {
            if (ModelState.IsValid)
            {
                _libraryservice.Delete(book.Id);
                return RedirectToAction("OnlineLibrary");
            }
            return View();
        }


        public IActionResult Edit(int id)
        {
            Book book = _libraryservice.GetById(id);
            if (book == null)
            {
                ErrorViewModel errorViewModel = new ErrorViewModel
                {
                    RequestId = id.ToString()
                };
                return View("Error", errorViewModel);
            }

            EditBookViewModel editBookViewModel = new EditBookViewModel
            {
                Isbn = book.Isbn,
                Name = book.Name,
                Description = book.Description,
                Author = book.Author,
                Quantity = book.Quantity
            };
            return View(editBookViewModel);
        }

        [HttpPost]
        public IActionResult Edit( EditBookViewModel bookModel)
        {
            Book book = _libraryservice.GetById(bookModel.Id);
            if (ModelState.IsValid)
            {
                book.Isbn = bookModel.Isbn;
                book.Name = bookModel.Name;
                book.Description = bookModel.Description;
                book.Author = bookModel.Author;
                book.Quantity = bookModel.Quantity;

                _libraryservice.Update(book);
                return View("OnlineLibrary");
            }
            return View();

        }


    }
}