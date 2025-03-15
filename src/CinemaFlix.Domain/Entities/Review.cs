namespace CinemaFlix.Domain.Entities;

public class Review : Entity
{
    public Review(string description, float rating, Movie movie, User user)
    {
        Description = description;
        Rating = rating;
        Movie = movie;
        User = user;
    }

    public string Description { get; private set; }
    public float Rating { get; private set; }
    public Movie Movie { get; private set; }
    public User User { get; private set; }
}