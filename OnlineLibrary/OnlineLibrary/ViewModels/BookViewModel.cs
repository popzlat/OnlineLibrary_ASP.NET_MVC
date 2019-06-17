using Microsoft.AspNetCore.Mvc.Rendering;
using OnlineLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineLibrary.ViewModels
{
    public class BookViewModel
    {

        [Required]
        [DisplayName("Id of the book")]
        public int Id { get; set; }

        public string Isbn { get; set; }

        [Required]
        [DisplayName("Book Name")]
        public string Name { get; set; }

        public List<GenreEnum> SelectGenre { get; set; }

        public string Description { get; set; }
        public Author Author { get; set; }
        public int Pages { get; set; }

        [Required]
        [DisplayName("Quantity of the book")]
        [MinLength(1)]
        public int Quantity { get; set; }



        public BookViewModel()
        {

            

            
        }
    }
}
