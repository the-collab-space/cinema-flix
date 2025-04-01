using CinemaFlix.Domain.Enums;
using CinemaFlix.Domain.ValueObjects;

namespace CinemaFlix.Domain.Entities;

public class User : Entity
{
    private readonly List<Guid> _favoriteMoviesIds = [];
    private readonly List<Guid> _watchListIds = [];
    private readonly List<Review> _reviews = [];

    private User()
    {
    }

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
    public IReadOnlyCollection<Guid> FavoriteMoviesIds => _favoriteMoviesIds.ToArray();
    public IReadOnlyCollection<Guid> WatchListIds => _watchListIds.ToArray();

    public void AddReviews(ICollection<Review> reviews) => _reviews.AddRange(reviews);
    public void AddFavoriteMovies(ICollection<Movie> movies) => _favoriteMoviesIds.AddRange(movies.Select(m => m.Id));
    public void AddMoviesToWatchList(ICollection<Movie> movies) => _watchListIds.AddRange(movies.Select(m => m.Id));
}