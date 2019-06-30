using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace OnlineBookLibrary.BusinessLayer
{
    public interface IAuthorService
    {
        List<SelectListItem> GetAllAuthors();
    }
}
