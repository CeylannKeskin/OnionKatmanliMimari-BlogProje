using Blog.Domain.Entities.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Domain.Repositories
{
    public interface IBaseRepository<T> where T : IBaseEntity
    {
        //Asenkron Programlamayı destekleyeceğiz....
        Task AddAsync(T entity);
        Task<int> UpdateAsync(T entity);
        Task DeleteAsync(T entity);


        Task<bool> AnyAsync(Expression<Func<T, bool>> predicate);

        //Istenilen bir kaydı bulmak için...
        Task<T> GetFirstOrDefaultAsync(Expression<Func<T, bool>> predicate);

        //GenreID=2
        Task<List<T>> GetDefaultsAsync(Expression<Func<T,bool>> predicate);

        Task<TResult> GetFilteredFirstOrDefaultAsync<TResult>(
            Expression<Func<T, TResult>> select,
            Expression<Func<T,bool>> where,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy=null,
            Func<IQueryable<T>, IIncludableQueryable<T,object>> include=null
            );

        Task<List<TResult>> GetFilteredListAsync<TResult>(
           Expression<Func<T, TResult>> select,
           Expression<Func<T, bool>> where,
           Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
           Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null
           );


        //Neden IEnumerable<T> değilde ??? IQuerable<T>
        //IQueryable() donen deger uzerinden Include() kullanılabilinir...
        //IEnumerable da olmaz...
        IQueryable<T> GetAll();

    }
}
