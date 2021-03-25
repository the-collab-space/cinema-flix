using CinemaFlix.Application.Common.Interfaces;
using CinemaFlix.Domain.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CinemaFlix.Infrastructure.Persistence.Repositories
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity, new()
    {
        protected readonly ApplicationDbContext Context;
        protected readonly DbSet<TEntity> DbSet;

        protected Repository(ApplicationDbContext context)
        {
            Context = context;
            DbSet = context.Set<TEntity>();
        }

        public async Task<IEnumerable<TEntity>> Search(Expression<Func<TEntity, bool>> predicate)
        {
            return await DbSet.AsNoTracking().Where(predicate).ToListAsync();
        }

        public async Task<List<TEntity>> FindAll()
        {
            return await DbSet.AsNoTracking().ToListAsync();
        }

        public async Task<TEntity> FindById(Guid id)
        {
            return await DbSet.FindAsync(id);
        }

        public async Task Add(TEntity entity)
        {
            DbSet.Add(entity);
            await SaveChanges();
        }

        public async Task AddRange(IEnumerable<TEntity> entities)
        {
            DbSet.AddRange(entities);
            await SaveChanges();
        }

        public async Task Update(TEntity entity)
        {
            DbSet.Update(entity);
            await SaveChanges();
        }

        public async Task Remove(Guid id)
        {
            DbSet.Remove(new TEntity { Id = id });
            await SaveChanges();
        }

        public async Task<int> SaveChanges()
        {
            return await Context?.SaveChangesAsync();
        }

        public void Dispose()
        {
            Context?.Dispose();
        }
    }
}
