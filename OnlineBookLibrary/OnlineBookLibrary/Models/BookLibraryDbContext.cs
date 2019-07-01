using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookLibrary.Models
{
    public class BookLibraryDbContext : DbContext
    {
        public BookLibraryDbContext(DbContextOptions<BookLibraryDbContext> options)
           : base(options)
        {

        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Loan> Loans { get; set; }
        public DbSet<LoanStatus> LoanStatuses { get; set; }
        public DbSet<UserRoll> UserRolls { get; set; }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Author>()
                .HasOne(x => x.Book)
                .WithOne(x => x.Author)
                .HasForeignKey<Book>(x => x.AuthorId);
          
            modelBuilder.Entity<UserRoll>()
                .HasKey(ur => new { ur.UserId, ur.RoleId});

            modelBuilder.Entity<UserRoll>()
                .HasOne(ur => ur.Role)
                .WithMany(x => x.UserRoles)
                .HasForeignKey(bc => bc.UserId);

            modelBuilder.Entity<UserRoll>()
                .HasOne(ur => ur.User)
                .WithMany(x => x.UserRoles)
                .HasForeignKey(bc => bc.RoleId)
                 .OnDelete(DeleteBehavior.Restrict); 

            modelBuilder.Entity<User>()
                .HasOne(x => x.Role)
                .WithOne(x => x.User)
                .HasForeignKey<Role>(x => x.UserId)
                 .OnDelete(DeleteBehavior.Restrict);



            //seed

            modelBuilder.Entity<Author>().HasData(new Author
            {
                Id = 1,
                Name = "Orson Scott",
                BookId = 1
                
            }, new Author
            {
                Id = 2,
                Name= "Truman Capote",
                BookId = 2

            }, new Author
            {
                Id = 3,
                Name = "Graeme Simsion",
                BookId = 3

            }, new Author
            {
                Id = 4,
                Name = "Ernest Hemingway"
            }, new Author
            {
                Id = 5,
                Name = "George R. R. Martin"
            }, new Author
            {
                Id = 6,
                Name = "Gillian Flynn"
            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 1,
                Description = "Ender's Game is a 1985 military science fiction novel by American author Orson Scott Card. Set at an unspecified date in Earth's future, the novel presents an imperiled humankind after two conflicts with the Formics, an insectoid alien species they dub the buggers.",
                Isbn = "0-312-93208-1",
                Genre = Genre.SciFi,
                Name = "Ender's Game",
                AuthorId = 1,
                Pages = 324,
                Quantity = 5
            }, new Book
            {
                Id = 2,
                Description = "In Cold Blood is a non-fiction novel by American author Truman Capote, first published in 1966; it details the 1959 murders of four members of the Herbert Clutter family in the small farming community of Holcomb, Kansas.",
                Isbn = "0-679-74558-0",
                Genre = Genre.Crime,
                Name = "In Cold Blood",
                AuthorId = 2,
                Pages = 343,
                Quantity = 10
            }, new Book
            {
                Id = 3,
                Description = "Don Tillman is an Australian genetics professor who has spent his days organizing his life with the expectation that it will reduce inefficiency, improve himself as a person, and make him an all around happier person.",
                Isbn = "9781922079770",
                Genre = Genre.Comedy,
                Name = "The Rosie Project",
                AuthorId = 3,
                Pages = 304,
                Quantity = 8
            }
            );

          

        }

    }
}
