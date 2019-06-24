using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineLibrary.Models;

namespace OnlineLibrary.Data
{
    public class BookRepository : ILibraryRepository
    {
        private readonly LibraryDbContext _libraryDbContext;

        public BookRepository(LibraryDbContext libraryDbContext)
        {
            _libraryDbContext = libraryDbContext;
        }



        public void Create(Book book)
        {
            throw new NotImplementedException();
        }

        public void Delete(Book book)
        {
            throw new NotImplementedException();
        }

        public Library GetBooks()
        {
            throw new NotImplementedException();
        }

        public Book GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Book book)
        {
            throw new NotImplementedException();
        }
    }
}
