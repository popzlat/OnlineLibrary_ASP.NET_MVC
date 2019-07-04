using OnlineBookLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookLibrary.ViewModels
{
    public class LoanViewModel
    {
        public int Id { get; set; }
        public int LoanBookId { get; set; }
        public Book Book { get; set; }
        public User User { get; set; }
        public DateTime LoanDate { get; set; }
        public LoanStatus Status { get; set; }
        public List<LoanedBooksViewModel> LoanedBooks { get; set; }

        public LoanViewModel()
        {
            LoanedBooks = new List<LoanedBooksViewModel>();
        }

    }
}
