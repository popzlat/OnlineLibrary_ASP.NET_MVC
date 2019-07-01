using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineBookLibrary.DataLayer;
using OnlineBookLibrary.Models;
using OnlineBookLibrary.ViewModels;

namespace OnlineBookLibrary.BusinessLayer
{
    public class BookService : IBookService

    {
        private readonly IRepository<Book> _bookRepository;
        private readonly IRepository<Author> _authorRepository;

        public BookService(IRepository<Book> bookRepository, IRepository<Author> authorRepository)
        {
            _bookRepository = bookRepository;
            _authorRepository = authorRepository;

        }

        public void CreateBook(BookViewModel model)
        {

            var author = _authorRepository.GetAll().FirstOrDefault(x=>x.Id == model.Id);
            Book book = new Book();
            book.Name = model.Name;
            book.Isbn = model.Isbn;
            book.Pages = model.Pages;
            book.Description = model.Description;
            book.Quantity = model.Quantity;
            book.Author = author;
            _bookRepository.Create(book);


        }

        public Book DeleteBook(int id)
        {
            var book = _bookRepository.GetBookById(id);
             _bookRepository.Delete(book);
            return book;

        }

        public List<Book> GetAll()
        {
            var books = _bookRepository.GetAll();
            return books.ToList();
        }

        public Book GetBookById(int id)
        {
           return _bookRepository.GetBookById(id);
        }

       
    }
}
