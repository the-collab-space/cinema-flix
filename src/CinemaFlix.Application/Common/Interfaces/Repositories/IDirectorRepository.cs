using CinemaFlix.Domain.Entities;

namespace CinemaFlix.Application.Common.Interfaces.Repositories;

public interface IDirectorRepository : IRepository<Director>
{
    Task<IEnumerable<Director>> GetDirectorsPerMovie(Guid movieId);
}