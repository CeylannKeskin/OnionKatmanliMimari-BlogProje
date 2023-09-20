using Blog.Domain.Entities.Abstract;
using Blog.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Infrastructure.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class, IBaseEntity
    {
        //Daha sonra IBaseRepository arayuzune ve buraya ekleme yapılacak....

        private readonly BlogContext _context;
        protected DbSet<T> _table;

        public BaseRepository(BlogContext context)
        {
            _context = context;
            _table = context.Set<T>();

        }

        public async Task AddAsync(T entity)
        {
            await _table.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

       

        public async Task DeleteAsync(T entity)
        {
            //Status => Passive olarak değişecek => Service içerisinde...
            await _context.SaveChangesAsync();
        }

        public async Task<int> UpdateAsync(T entity)
        {
            // _context.Update(entity);
            _context.Entry<T>(entity).State = EntityState.Modified;
            return await _context.SaveChangesAsync();
        }

        public async Task<bool> AnyAsync(Expression<Func<T, bool>> predicate)
        {
            return await _table.AnyAsync(predicate);
        }

        public async Task<T> GetFirstOrDefaultAsync(Expression<Func<T, bool>> predicate)
        {
            return await _table.FirstOrDefaultAsync(predicate);
        }

        public async Task<List<T>> GetDefaultsAsync(Expression<Func<T, bool>> predicate)
        {
            return await _table.Where(predicate).ToListAsync();
        }

        public async Task<TResult> GetFilteredFirstOrDefaultAsync<TResult>(Expression<Func<T, TResult>> select, Expression<Func<T, bool>> where, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null)
        {
            IQueryable<T> query = _table;

            if(where!=null)
                query = query.Where(where);
            
            if(include != null)
                query = include(query);

            if (orderBy != null)
                return await orderBy(query).Select(select).SingleOrDefaultAsync();

            return await query.Select(select).SingleOrDefaultAsync();
        }

        public async Task<List<TResult>> GetFilteredListAsync<TResult>(Expression<Func<T, TResult>> select, Expression<Func<T, bool>> where, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null)
        {
            IQueryable<T> query = _table;

            if (where != null)
                query = query.Where(where);

            if (include != null)
                query = include(query);

            if (orderBy != null)
                return await orderBy(query).Select(select).ToListAsync();

            return await query.Select(select).ToListAsync();
        }

        public IQueryable<T> GetAll()
        {
            return _table.AsQueryable();
        }
    }
}
