using OnlineBookLibrary.Models;
using OnlineBookLibrary.ViewModels;
using System.Collections.Generic;

namespace OnlineBookLibrary.BusinessLayer
{
    public interface IBookService
    {
        List<Book> GetAll();
        Book GetBookById(int id);
        void CreateBook(BookViewModel model);
        Book DeleteBook(int id);
    }
}
