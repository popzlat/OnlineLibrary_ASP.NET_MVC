using System.Collections.Generic;

namespace OnlineLibrary.Models
{
    public class Library
    {
        public string Name { get; set; }
        public List<Book> ListOfBooks { get; set; }

        public Library( string name,List<Book> books)
        {
            Name = name;
            ListOfBooks = books;
        }
    }
}
