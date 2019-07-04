using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using OnlineBookLibrary.DataLayer;
using OnlineBookLibrary.Models;

namespace OnlineBookLibrary.BusinessLayer
{
    public class AuthorService : IAuthorService
    {
        private readonly IRepository<Author> _authorReopsitory;

        public AuthorService(IRepository<Author> authorReopsitory)
        {
            _authorReopsitory = authorReopsitory;
        }


        public List<SelectListItem> GetAllAuthors()
        {
            return _authorReopsitory.GetAll().Select(x => new SelectListItem()
            {
                Value = x.Id.ToString(),
                Text = x.Name
            }).ToList();
        }

        public List<Author> ListAllAuthors()
        {
            return _authorReopsitory.GetAll().ToList();
        }
    }
}
