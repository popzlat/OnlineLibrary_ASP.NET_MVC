using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookLibrary.Models
{
    public class Book
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Isbn { get; set; }
        public string Name { get; set; }
        public Genre Genre { get; set; }
        public string Description { get; set; }
        public Author Author { get; set; }
        public int AuthorId { get; set; }
        public int Pages { get; set; }
        public int Quantity { get; set; }


        public void IncraseQuantity(int aditionalQuantity)
        {
            var currentQuantity = this.Quantity;
            Quantity = aditionalQuantity + currentQuantity;
        }
        public void RemoveCopy(int removedCopy)
        {
            var currentQuantity = this.Quantity;
            Quantity = currentQuantity - removedCopy;

        }
        public Book()
        {

        }
       
    }
}
