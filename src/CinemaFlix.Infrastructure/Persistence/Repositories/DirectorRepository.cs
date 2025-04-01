using CinemaFlix.Application.Common.Interfaces.Repositories;
using CinemaFlix.Domain.Entities;

namespace CinemaFlix.Infrastructure.Persistence.Repositories;

public class DirectorRepository  : Repository<Director>, IDirectorRepository
{
    public DirectorRepository(ApplicationDbContext context) : base(context)
    {
    }

    public async Task<IEnumerable<Director>> GetDirectorsPerMovie(Guid movieId) =>
        await Search(d => d.Movies.AsEnumerable().All(m => m.Id == movieId));
}