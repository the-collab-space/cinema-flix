using CinemaFlix.Application.Common.Interfaces.Repositories;
using CinemaFlix.Domain.Entities;

namespace CinemaFlix.Infrastructure.Persistence.Repositories;

public class ActorRepository  : Repository<Actor>, IActorRepository
{
    public ActorRepository(ApplicationDbContext context) : base(context)
    {
    }

    public async Task<IEnumerable<Actor>> GetActorsPerMovie(Guid movieId)=>
        await Search(a => a.Movies.AsEnumerable().All(m => m.Id == movieId));
}