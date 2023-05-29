using Blog.Core.Entities;
using Blog.Data.Context;
using Blog.Data.Repositories.Abstractions;
using Blog.Data.Repositories.Concretes;
using Microsoft.EntityFrameworkCore;

namespace Blog.Data.UnitOfWorks;

public class UnitOfWork : IUnitOfWorks
{
    private readonly AppDbContext dbContext;

    public UnitOfWork(AppDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public async ValueTask DisposeAsync()
    {
        await dbContext.DisposeAsync();
    }

    public IRepository<T> GetRepository<T>() where T : class, IEntityBase, new()
    {
        return new Repository<T>(dbContext);
    }

    public async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        return await dbContext.SaveChangesAsync(cancellationToken);
    }

    public int Save()
    {
        return  dbContext.SaveChanges();
    }
}