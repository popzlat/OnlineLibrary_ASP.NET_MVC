using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineLibrary.Models
{
    public class LibraryDbContext : DbContext
    {

        public LibraryDbContext(DbContextOptions<LibraryDbContext> options ): base(options)
        {

        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Library> Librarys { get; set; }
        public DbSet<Loan> Loans { get; set; }
        public DbSet<LoanStatus> LoanStatus { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
