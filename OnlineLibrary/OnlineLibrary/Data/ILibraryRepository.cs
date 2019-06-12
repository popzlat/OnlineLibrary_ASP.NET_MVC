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

    }
}
