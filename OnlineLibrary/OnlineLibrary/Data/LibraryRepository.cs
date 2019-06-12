using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineLibrary.Models;

namespace OnlineLibrary.Data
{
    public class LibraryRepository : ILibraryRepository
    {
        public Library GetBooks()
        {
            return Storage.Books;
        }
    }
}
