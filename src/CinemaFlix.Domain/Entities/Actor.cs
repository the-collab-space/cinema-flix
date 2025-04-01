using CinemaFlix.Domain.Enums;
using CinemaFlix.Domain.Interfaces;
using CinemaFlix.Domain.ValueObjects;
using NodaTime;

namespace CinemaFlix.Domain.Entities;

public class Actor : Entity, IPerson, ICast
{
    private readonly List<Movie> _movies = [];

    private Actor()
    {
    }

    public Actor(Name name, LocalDate birthDate, ICollection<Movie> movies,
        EGender gender = EGender.NonBinary, string? description = null)
    {
        Name = name;
        Gender = gender;
        BirthDate = birthDate;
        Description = description;
        AddMovies(movies);
    }

    public Name Name { get; private set; }
    public ushort Age => (ushort)(LocalDate.FromDateTime(DateTime.UtcNow) - BirthDate).Years;
    public LocalDate BirthDate { get; private set; }
    public EGender Gender { get; private set; }
    public string? Description { get; private set; }
    public IReadOnlyCollection<Movie> Movies => _movies.ToArray();

    public void AddMovies(ICollection<Movie> movies) => _movies.AddRange(movies);
}