using CinemaFlix.Domain.Enums;
using CinemaFlix.Domain.Interfaces;
using CinemaFlix.Domain.ValueObjects;
using NodaTime;

namespace CinemaFlix.Domain.Entities;

public class Director : Entity, IPerson, ICrew
{
    private readonly List<Movie> _movies = [];

    private Director() { }
    
    public Director(Name name, ICollection<Movie> movies, LocalDate birthDate, EGender gender = EGender.NonBinary, string? description = null)
    {
        Name = name;
        BirthDate = birthDate;
        Description = description;
        Gender = gender;
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