using Microsoft.AspNetCore.Mvc.Rendering;
using OnlineBookLibrary.Models;
using System.Collections.Generic;

namespace OnlineBookLibrary.BusinessLayer
{
    public interface IAuthorService
    {
        List<SelectListItem> GetAllAuthors();
        List<Author> ListAllAuthors();
    }
}
