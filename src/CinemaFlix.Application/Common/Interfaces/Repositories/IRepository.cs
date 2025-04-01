using System.Linq.Expressions;
using CinemaFlix.Domain.Entities;

namespace CinemaFlix.Application.Common.Interfaces.Repositories;

public interface IRepository<TEntity> : IDisposable where TEntity : Entity
{
    Task<List<TEntity>> FindAll();
    Task<TEntity?> FindById(Guid id);
    Task<IEnumerable<TEntity>> Search(Expression<Func<TEntity, bool>> predicate);
    Task<int> Add(TEntity entity);
    Task AddRange(IEnumerable<TEntity> entities);
    Task<int> Update(TEntity entity);
    Task<int> Remove(TEntity entity);
    Task<int> SaveChanges();
}