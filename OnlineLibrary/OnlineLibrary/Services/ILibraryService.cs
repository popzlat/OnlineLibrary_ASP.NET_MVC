using OnlineLibrary.Models;
using OnlineLibrary.ViewModels;

namespace OnlineLibrary.Services
{
    public interface ILibraryService
    {
        Library GetBooks();
        void Create(BookViewModel book);
    }
}
