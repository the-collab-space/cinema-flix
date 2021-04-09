using CinemaFlix.Application.Common.Interfaces;
using CinemaFlix.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaFlix.Infrastructure.Persistence.Repositories
{
    public class MovieRepository : Repository<Movie>, IMovieRepository
    {
        public MovieRepository(ApplicationDbContext context) : base(context) { }

        public async Task<ICollection<Movie>> GetMoviesByActor(Guid ActorId)
        {
            return await Context.Movies.AsNoTracking().Include(a => a.Actors.FirstOrDefault(a => a.Id == ActorId)).ToListAsync();
        }
    }
}
