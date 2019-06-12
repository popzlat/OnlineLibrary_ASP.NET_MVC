using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineLibrary.Models
{
    public class Library
    {
        private string Name;
        private List<Book> books;

        public string LibraryName { get; set; }
        public Book Books { get; set; }

        

        public Library(string name, List<Book> books)
        {
            this.Name = name;
            this.books = books;
        }
    }
}
