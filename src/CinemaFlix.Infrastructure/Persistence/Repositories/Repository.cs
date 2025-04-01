using System.Linq.Expressions;
using CinemaFlix.Application.Common.Interfaces.Repositories;
using CinemaFlix.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CinemaFlix.Infrastructure.Persistence.Repositories;

public class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity
{
    private bool _disposed;

    protected readonly ApplicationDbContext Context;
    protected readonly DbSet<TEntity> DbSet;

    public Repository(ApplicationDbContext context)
    {
        Context = context;
        DbSet = Context.Set<TEntity>();
    }

    public async Task<List<TEntity>> FindAll() => await DbSet.AsNoTracking().ToListAsync();

    public async Task<TEntity?> FindById(Guid id) => await DbSet.FindAsync(id);

    public async Task<IEnumerable<TEntity>> Search(Expression<Func<TEntity, bool>> predicate) =>
        await DbSet.AsNoTracking().Where(predicate).ToListAsync();

    public async Task<int> Add(TEntity entity)
    {
        DbSet.Add(entity);
        return await SaveChanges();
    }

    public async Task AddRange(IEnumerable<TEntity> entities)
    {
        DbSet.AddRange(entities);
        await SaveChanges();
    }

    public async Task<int> Update(TEntity entity)
    {
        DbSet.Update(entity);
        return await SaveChanges();
    }

    public async Task<int> Remove(TEntity entity)
    {
        DbSet.Remove(entity);
        return await SaveChanges();
    }

    public async Task<int> SaveChanges() => await Context.SaveChangesAsync();

    public void Dispose()
    {
        if (_disposed) return;

        Context.Dispose();
        GC.SuppressFinalize(this);
        _disposed = true;
    }
}