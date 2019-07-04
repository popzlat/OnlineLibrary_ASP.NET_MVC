using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnlineBookLibrary.BusinessLayer;

namespace OnlineBookLibrary.Controllers
{
    public class AuthorController : Controller
    {

        private readonly IAuthorService _authorService;

        public AuthorController(IAuthorService authorService )
        {
            _authorService = authorService;
        }

        public IActionResult ListAllAuthors()
        {
            var author = _authorService.ListAllAuthors();
            return View(author);
        }
    }
}