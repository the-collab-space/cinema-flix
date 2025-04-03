using NodaTime;

namespace CinemaFlix.Domain.Entities;

public abstract class Entity
{
    public Guid Id { get; init; } = Guid.CreateVersion7();
    public Instant CreateDate { get; init; } = Instant.FromDateTimeOffset(DateTimeOffset.Now);
    public Instant? UpdateDate { get; protected set; }
}