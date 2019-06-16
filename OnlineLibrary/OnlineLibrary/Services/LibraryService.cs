using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineLibrary.Data;
using OnlineLibrary.Models;

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
    }
}
