using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineLibrary.Models
{
    public class Book
    {

        public int Id { get; set; }
        public string Isbn { get; set; }
        public string Name { get; set; }
        public GenreEnum Genre { get; set; }
        public string Description { get; set; }
        public Author Author { get; set; }
        public int Pages { get; set; }
        public int Quantity { get; set; }


        void incraseQuantity( int aditionalQuantity)
            {
            }

        void removeCopy()
        {

        }


    }
}
