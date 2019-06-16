using OnlineLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineLibrary.Data
{
 public interface ILibraryRepository
    {
        Library GetBooks();

        void Create(Book book);
        void Update(Book book);
        void Delete(Book book);
        
    }
}
