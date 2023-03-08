using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MockInterview.Data.IRepositories;
using MockInterview.Domain.Commons;

namespace MockInterview.Data.Repositories;

public class GenericRepository<T> : IGenericRepository<T> where T : Auditable
{
    private readonly DbContext dbContext;
    private readonly DbSet<T> dbSet;

    public GenericRepository(DbContext dbContext, DbSet<T> dbSet)
    {
        this.dbContext = dbContext;
        this.dbSet = dbContext.Set<T>();
    }

    public async ValueTask<T> CreateAsync(T entity) =>
        (await dbSet.AddAsync(entity)).Entity;

    public T Update(T entity) =>
        dbSet.Update(entity).Entity;

    public async ValueTask<bool> DeleteAsync(int id)
    {
        var entity = await GetAsync(e => e.Id == id);

        if (entity is null)
            return false;

        dbSet.Remove(entity);
        return true;
    }

    public async ValueTask<T> GetAsync(Expression<Func<T, bool>> expression) =>
        await dbSet.FirstOrDefaultAsync(expression);

    public IQueryable<T> GetAll(Expression<Func<T, bool>> expression,
        string[] includes = null,
        bool isTracking = true)
    {
        IQueryable<T> query = expression is null ? dbSet : dbSet.Where(expression);

        if (includes != null)
            foreach (var include in includes)
                if (!string.IsNullOrEmpty(include))
                    query = query.Include(include);

        if (!isTracking)
            query = query.AsNoTracking();

        return query;
    }

    public async ValueTask SaveChangesAsync() =>
        await dbContext.SaveChangesAsync();
}