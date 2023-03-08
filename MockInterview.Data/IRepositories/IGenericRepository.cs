using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using MockInterview.Domain.Commons;

namespace MockInterview.Data.IRepositories;

public interface IGenericRepository<T> where T : Auditable
{
    ValueTask<T> CreateAsync(T entity);
    T Update(T entity);
    ValueTask<bool> DeleteAsync(int id);
    ValueTask<T> GetAsync(Expression<Func<T, bool>> expression);
    IQueryable<T> GetAll(Expression<Func<T, bool>> expression,
        string[] includes = null,
        bool isTracking = true);
    ValueTask SaveChangesAsync();
}