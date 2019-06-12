using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineLibrary.Models
{
    public class Author
    {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        public Author(int id,string firstName,string lastName)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }
}
