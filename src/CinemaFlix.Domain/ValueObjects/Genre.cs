namespace CinemaFlix.Domain.ValueObjects;

public class Genre
{
    public Genre(string name)
    {
        Name = name;
    }

    public string Name { get; private set; }
}