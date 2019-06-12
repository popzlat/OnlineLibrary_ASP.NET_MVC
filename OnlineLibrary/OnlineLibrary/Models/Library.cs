using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineLibrary.Models
{
    public class Library
    {
        public string LibraryName { get; set; }
        public List<Book> Books { get; set; }


        public Library(string libraryName, List<Book> bookList)
        {   

            LibraryName = libraryName;
            Books = bookList;
        }
        
    }
}
