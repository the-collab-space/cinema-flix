using CinemaFlix.Domain.Entities;

namespace CinemaFlix.Application.Common.Interfaces.Repositories;

public interface IMovieRepository : IRepository<Movie>
{
    Task<IEnumerable<Movie>> GetMoviePerActor(Guid actorId);
    Task<IEnumerable<Movie>> GetMoviePerDirector(Guid directorId);
}