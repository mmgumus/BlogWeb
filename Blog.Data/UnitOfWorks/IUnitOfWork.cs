using Blog.Core.Entities;
using Blog.Data.Repositories.Abstractions;

namespace Blog.Data.UnitOfWorks;

public interface IUnitOfWork : IAsyncDisposable
{
    IRepository<T> GetRepository<T>() where T : class, IEntityBase, new();

    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    int Save();
}