using CinemaFlix.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CinemaFlix.Application.Common.Interfaces;

public interface IApplicationDbContext
{
    DbSet<Movie> Movies { get; set; }
    DbSet<Actor> Actors { get; set; }
    DbSet<Director> Directors { get; set; }
    DbSet<Review> Reviews { get; set; }
    DbSet<User> Users { get; set; }
}