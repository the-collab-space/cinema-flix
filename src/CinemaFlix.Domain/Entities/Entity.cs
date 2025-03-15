namespace CinemaFlix.Domain.Entities;

public abstract class Entity
{
    public Guid Id { get; init; } = Guid.CreateVersion7();
    public DateTimeOffset CreateDate { get; init; } = DateTimeOffset.Now;
    public DateTimeOffset? UpdateDate { get; protected set; }
}