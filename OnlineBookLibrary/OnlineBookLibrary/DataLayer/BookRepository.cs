using OnlineBookLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookLibrary.DataLayer
{
    public class BookRepository : IRepository<Book>
    {
        private readonly BookLibraryDbContext _dbContext;

        public BookRepository(BookLibraryDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        public void Create(Book obj)
        {
            _dbContext.Books.Add(obj);
            _dbContext.SaveChanges();
        }

        public void Delete(Book obj)
        {
            _dbContext.Books.Remove(obj);
            _dbContext.SaveChanges();
        }

        public List<Book> GetAll()
        {
            var dbSet = _dbContext.Books;
            return dbSet.ToList();
        }

        public Book GetBookById(int id)
        {
            var dbSet = _dbContext.Books;
            return dbSet.FirstOrDefault(x => x.Id == id);
        }

        public void Update(Book obj)
        {
            _dbContext.Books.Update(obj);
            _dbContext.SaveChanges();
        }
    }
}
