using OnlineLibrary.Models;
using OnlineLibrary.ViewModels;

namespace OnlineLibrary.Services
{
    public interface ILibraryService
    {
        Library GetBooks();
        Book GetById(int id);
        void Create(BookViewModel book);
        Book Delete(int id);
        Book Update(Book book);
    }
}
