using CinemaFlix.Domain.Entities;

namespace CinemaFlix.Application.Common.Interfaces.Repositories;

public interface IActorRepository : IRepository<Actor>
{
    Task<IEnumerable<Actor>> GetDirectorsPerMovie(Guid movieId);
}