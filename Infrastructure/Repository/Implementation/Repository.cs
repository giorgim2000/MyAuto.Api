using Infrastructure.DataContext;
using Infrastructure.Repository.Abstraction;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository.Implementation
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly ApplicationDbContext _context;
        public Repository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Create(T input)
        {
            await _context.Set<T>().AddAsync(input);
        }

        public void Update(T input)
        {
            _context.Set<T>().Update(input);
        }
        public void Delete(T input)
        {
            _context.Set<T>().Remove(input);
        }
        public async Task<IEnumerable<T>> GetCollectionAsync(Expression<Func<T,bool>> expression = null)
        {
            return expression == null ? await _context.Set<T>().AsNoTracking().ToListAsync() : await _context.Set<T>().AsNoTracking().Where(expression).ToListAsync();
        }

        public IQueryable<T> GetQuery(Expression<Func<T,bool>> expression = null)
        {
            return expression == null ? _context.Set<T>() : _context.Set<T>().Where(expression);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync()) > 0;
        }
    }
}
