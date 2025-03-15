using CinemaFlix.Domain.Entities;

namespace CinemaFlix.Domain.Interfaces;

public interface ICast
{
    string? Description { get; }
    public IReadOnlyCollection<Movie> Movies { get; }
}