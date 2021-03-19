using Microsoft.EntityFrameworkCore;
using CinemaFlix.Domain.Entities;

namespace CinemaFlix.Application.Common.Interfaces
{
    public interface IApplicationDbContext 
    {
        DbSet<Movie> Movies { get; set; }
        DbSet<Actor> Actors { get; set; }
        DbSet<Character> Characters { get; set; }
        DbSet<Director> Directors { get; set; }
        DbSet<Genre> Genres { get; set; }
        DbSet<Language> Languages { get; set; }
        DbSet<Picture> Pictures { get; set; }
        DbSet<User> Users { get; set; }
    }
}
