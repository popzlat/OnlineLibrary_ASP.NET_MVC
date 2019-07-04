using OnlineBookLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookLibrary.ViewModels
{
    public class LoanedBooksViewModel
    {
        public BookViewModel Book { get; set; }
        public Genre Genre { get; set; }
        public int Quantity { get; set; }
    }
}
