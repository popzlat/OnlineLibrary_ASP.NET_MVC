using Microsoft.AspNetCore.Mvc.Rendering;
using OnlineLibrary.Data;
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
        [DisplayName("ISBN")]
        public string Isbn { get; set; }

        [Required]
        [DisplayName("Book Name")]
        public string Name { get; set; }

        public List<GenreEnum> SelectGenre { get; set; }

        [Required]
        [DisplayName("Description")]
        public string Description { get; set; }

        [Required]
        [DisplayName("Author name")]
        public string Author { get; set; }
        public int Pages { get; set; }


        [Required]
        [DisplayName("Quantity of the book")]
        public int Quantity { get; set; }


        public BookViewModel()
        {



        }
    }
}
