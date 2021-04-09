using CinemaFlix.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CinemaFlix.Application.Common.Interfaces
{
    public interface IMovieRepository : IRepository<Movie>
    {
        Task<ICollection<Movie>> GetMoviesByActor(Guid ActorId);
    }
}
