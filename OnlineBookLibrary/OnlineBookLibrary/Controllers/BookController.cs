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
        public BookController(IBookService bookService)
        {
            _bookService = bookService;
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
            var book = new BookViewModel();
            return View(book);
        }

        //[HttpPost]
        //public IActionResult Create(BookViewModel model)
        //{


        //}

    }
}