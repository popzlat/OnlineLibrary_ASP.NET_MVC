using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineLibrary.Models
{
    public class Loan
    {
        public int Id { get; set; }
        public Book Book { get; set; }
        public User User { get; set; }
        public DateTime LoanDate { get; set; }
        public LoanStatus Status { get; set; }
    }
}
