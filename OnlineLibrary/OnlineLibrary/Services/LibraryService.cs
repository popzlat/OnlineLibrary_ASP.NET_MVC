using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineLibrary.Data;
using OnlineLibrary.Models;
using OnlineLibrary.ViewModels;

namespace OnlineLibrary.Services
{
    public class LibraryService : ILibraryService
    {
        private readonly ILibraryRepository _libraryRepository;


        public LibraryService( ILibraryRepository libraryRepository)
        {
            _libraryRepository = libraryRepository;
        }


        public Library GetBooks()
        {
            return _libraryRepository.GetBooks();
        }

        public void Create(BookViewModel book)
        {
            int  nextId = Storage.Books.Last().Id + 1;

            var bookModel = new Book(nextId,book.Isbn,book.Name,GenreEnum.Comedy,book.Description,book.Author,book.Pages,book.Quantity);

            _libraryRepository.Create(bookModel);
        }

        public Book GetById(int id)
        {
            return Storage.Books.FirstOrDefault(x => x.Id == id);

        }

        public Book Delete(int id)
        {
            var book = Storage.Books.FirstOrDefault(x => x.Id == id);
            _libraryRepository.Delete(book);
            return book;
        }

        public Book Update(Book book)
        {
            var obj = Storage.Books.FirstOrDefault(x => x.Id == book.Id);

            if (obj != null)
            {
                Storage.Books.Remove(obj);
                Storage.Books.Add(book);
            }
            return book;
        }
    }
}
