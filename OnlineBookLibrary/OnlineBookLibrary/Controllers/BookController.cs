using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnlineBookLibrary.BusinessLayer;
using OnlineBookLibrary.Models;
using OnlineBookLibrary.ViewModels;

namespace OnlineBookLibrary.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookService _bookService;
        private readonly IAuthorService _authorService;
        public BookController(IBookService bookService, IAuthorService authorService)
        {
            _bookService = bookService;
            _authorService = authorService;
        }

        public IActionResult Index()
        {
            List<Book> books = _bookService.GetAll();

            return View(books);
        }

        public IActionResult Details(int id)
        {
            Book book = _bookService.GetBookById(id);
            return View(book);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var book = new BookViewModel() { AllAuthors = _authorService.GetAllAuthors() };
            return View(book);
        }

        [HttpPost]
        public IActionResult Create(BookViewModel model)
        {
            _bookService.CreateBook(model);
            return RedirectToAction("Index", "Book");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var book = _bookService.GetBookById(id);
            _bookService.DeleteBook(book.Id);
            return RedirectToAction("Index", "Book");
        }

       

    }
}