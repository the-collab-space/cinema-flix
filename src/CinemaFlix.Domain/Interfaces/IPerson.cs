using CinemaFlix.Domain.Enums;
using CinemaFlix.Domain.ValueObjects;
using NodaTime;

namespace CinemaFlix.Domain.Interfaces;

public interface IPerson
{
    public Name Name { get; }
    public ushort Age { get; }
    public LocalDate BirthDate { get; }
    public EGender Gender { get; }
}