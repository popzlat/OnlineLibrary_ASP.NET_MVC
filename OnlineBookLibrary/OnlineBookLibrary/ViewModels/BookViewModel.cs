using Microsoft.AspNetCore.Mvc.Rendering;
using OnlineBookLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookLibrary.ViewModels
{
    public class BookViewModel
    {

        public int Id { get; set; }

        [DisplayName("ISBN")]
        public string Isbn { get; set; }

        [DisplayName("Book Name")]
        public string Name { get; set; }

        [DisplayName("Book Genre")]
        public List<SelectListItem> AllGenres { get; set; }

        [DisplayName("Description")]
        public string Description { get; set; }

        [DisplayName("Author Name")]
        public List<SelectListItem> AllAuthors { get; set; }

        [DisplayName("Pages")]
        public int Pages { get; set; }

        [DisplayName("Quantity of the book")]
        public int Quantity { get; set; }


        public BookViewModel()
        {
            AllGenres = new List<SelectListItem>();
            AllAuthors = new List<SelectListItem>();
        }
    }
}
