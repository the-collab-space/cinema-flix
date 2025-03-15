using CinemaFlix.Domain.Entities;

namespace CinemaFlix.Domain.Interfaces;

public interface ICrew
{
    string? Description { get; }
    public IReadOnlyCollection<Movie> Movies  { get; }
}