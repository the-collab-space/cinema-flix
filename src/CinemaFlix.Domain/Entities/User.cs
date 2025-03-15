using CinemaFlix.Domain.Enums;
using CinemaFlix.Domain.ValueObjects;

namespace CinemaFlix.Domain.Entities;

public class User : Entity
{
    private readonly List<Movie> _favoriteMovies = [];
    private readonly List<Movie> _watchList = [];
    private readonly List<Review> _reviews = [];

    public User(Name name, string password, Email email, ERole role = ERole.Default)
    {
        Name = name;
        Role = role;
        Email = email;
        Password = password;
    }

    public User(Name name, string password, Email email, ICollection<Review> reviews,
        ICollection<Movie> favoriteMovies, ICollection<Movie> watchList, ERole role = ERole.Default)
        : this(name, password, email, role)
    {
        AddReviews(reviews);
        AddFavoriteMovies(favoriteMovies);
        AddMoviesToWatchList(watchList);
    }

    public Name Name { get; private set; }
    public Email Email { get; private set; }
    public string Password { get; private set; }
    public ERole Role { get; private set; }
    public IReadOnlyCollection<Review> Reviews => _reviews.ToArray();
    public IReadOnlyCollection<Movie> FavoriteMovies => _favoriteMovies.ToArray();
    public IReadOnlyCollection<Movie> WatchList => _watchList.ToArray();

    public void AddReviews(ICollection<Review> reviews) => _reviews.AddRange(reviews);
    public void AddFavoriteMovies(ICollection<Movie> movies) => _favoriteMovies.AddRange(movies);
    public void AddMoviesToWatchList(ICollection<Movie> movies) => _watchList.AddRange(movies);
}