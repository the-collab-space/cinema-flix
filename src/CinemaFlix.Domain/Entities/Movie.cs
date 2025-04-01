using CinemaFlix.Domain.ValueObjects;
using NodaTime;

namespace CinemaFlix.Domain.Entities;

public class Movie : Entity
{
    private readonly List<Actor> _actors = [];
    private readonly List<Director> _directors = [];
    private readonly List<Genre> _genres = [];

    private Movie() { }
    
    public Movie(string title, ICollection<Genre> genres, LocalDate releaseDate, ICollection<Director> directors,
        ICollection<Actor> actors, bool adult = false, TimeSpan? duration = null, float? rating = null,
        string? synopsis = null)
    {
        Title = title;
        Synopsis = synopsis;
        ReleaseDate = releaseDate;
        Adult = adult;
        Duration = duration;
        Rating = rating;
        AddGenres(genres);
        AddDirectors(directors);
        AddActors(actors);
    }

    public string Title { get; private set; }
    public string? Synopsis { get; private set; }
    public bool Adult { get; private set; }
    public LocalDate ReleaseDate { get; private set; }
    public TimeSpan? Duration { get; private set; }
    public float? Rating { get; private set; }
    public IReadOnlyCollection<Genre> Genres => _genres.ToArray();
    public IReadOnlyCollection<Director> Directors => _directors.ToArray();
    public IReadOnlyCollection<Actor> Actors => _actors.ToArray();

    public void AddActors(ICollection<Actor> actors) => _actors.AddRange(actors);
    public void AddGenres(ICollection<Genre> genres) => _genres.AddRange(genres);
    public void AddDirectors(ICollection<Director> directors) => _directors.AddRange(directors);
}