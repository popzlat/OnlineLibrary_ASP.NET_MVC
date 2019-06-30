using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookLibrary.Models
{
    public class Loan
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int LoanBookId { get; set; }
        public Book Books { get; set; }
        public User User { get; set; }
        public DateTime LoanDate { get; set; }
        public LoanStatus Status { get; set; }
    }
}
