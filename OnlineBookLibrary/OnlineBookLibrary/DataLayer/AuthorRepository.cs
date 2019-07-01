using OnlineBookLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookLibrary.DataLayer
{
    public class AuthorRepository : IRepository<Author>
    {
        private readonly BookLibraryDbContext _dbContext;

        public AuthorRepository(BookLibraryDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Create(Author obj)
        {
            _dbContext.Authors.Add(obj);
            _dbContext.SaveChanges();
        }

        public void Delete(Author obj)
        {
            _dbContext.Authors.Remove(obj);
            _dbContext.SaveChanges();
        }

        public List<Author> GetAll()
        {
            var dbSet = _dbContext.Authors;
            return dbSet.ToList();
        }

        public Author GetBookById(int id)
        {
            var dbSet = _dbContext.Authors;
            return dbSet.FirstOrDefault(x => x.Id == id);
        }

        public void Update(Author obj)
        {
            _dbContext.Authors.Update(obj);
            _dbContext.SaveChanges();
        }
    }
}
