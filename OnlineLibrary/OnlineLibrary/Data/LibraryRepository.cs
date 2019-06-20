using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineLibrary.Models;

namespace OnlineLibrary.Data
{
    public class LibraryRepository: ILibraryRepository
    {
        public void Create(Book book)
        {
            Storage.Books.Add(book);
        }

        public void Delete(Book book)
        {
            Storage.Books.Remove(book);
        }

        public Library GetBooks()
        {
            return Storage.NewLibrary;
        }

        public Book GetById(int id)
        {
           return Storage.Books.FirstOrDefault(x => x.Id == id);
        }

        public void Update(Book book)
        {
            var obj = Storage.Books.FirstOrDefault(x => x.Id == book.Id);

            if (obj != null)
            {
                Storage.Books.Remove(obj);
                Storage.Books.Add(book);
            }
        }
    }
}
