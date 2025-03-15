using CinemaFlix.Domain.Enums;
using CinemaFlix.Domain.Interfaces;
using CinemaFlix.Domain.ValueObjects;

namespace CinemaFlix.Domain.Entities;

public class Director : Entity, IPerson, ICrew
{
    private readonly List<Movie> _movies = [];

    public Director(Name name, ushort age, ICollection<Movie> movies, DateOnly birthDate, EGender gender = EGender.NonBinary, string? description = null)
    {
        Name = name;
        Age = age;
        BirthDate = birthDate;
        Description = description;
        Gender = gender;
        AddMovies(movies);
    }

    public Name Name { get; private set; }
    public ushort Age { get; private set; }
    public DateOnly BirthDate { get; private set; }
    public EGender Gender { get; private set; }
    public string? Description { get; private set; }
    public IReadOnlyCollection<Movie> Movies => _movies.ToArray();

    public void AddMovies(ICollection<Movie> movies) => _movies.AddRange(movies);
}