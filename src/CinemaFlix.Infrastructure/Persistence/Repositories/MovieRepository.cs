using CinemaFlix.Application.Common.Interfaces.Repositories;
using CinemaFlix.Domain.Entities;

namespace CinemaFlix.Infrastructure.Persistence.Repositories;

public class MovieRepository : Repository<Movie>, IMovieRepository
{
    public MovieRepository(ApplicationDbContext context) : base(context)
    {
    }

    public async Task<IEnumerable<Movie>> GetMoviePerActor(Guid actorId) =>
        await Search(m => m.Actors.AsEnumerable().All(a => a.Id == actorId));

    public async Task<IEnumerable<Movie>> GetMoviePerDirector(Guid directorId) =>
        await Search(m => m.Directors.AsEnumerable().All(d => d.Id == directorId));
}