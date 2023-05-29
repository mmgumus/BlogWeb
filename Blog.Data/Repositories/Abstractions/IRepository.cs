using Blog.Core.Entities;
using System.Linq.Expressions;

namespace Blog.Data.Repositories.Abstractions;

public interface IRepository<T> where T : class, IEntityBase, new()
{
    Task AddAsync(T entity);

    Task<List<T>> GetAllAsync(Expression<Func<T, bool>> predicate = null,
        params Expression<Func<T, object>>[] includeProperties);

    Task<T> GetAsync(Expression<Func<T, bool>> predicate,
        params Expression<Func<T, object>>[] includeProperties);

    Task<T> GetByIdAsync(Guid id);
    Task UpdateAsync(T entity);
    Task DeleteAsync(T entity);

    Task<bool> AnyAsync(Expression<Func<T, bool>> predicate = null);

    Task<int> CountAsync(Expression<Func<T, bool>> predicate = null);
}