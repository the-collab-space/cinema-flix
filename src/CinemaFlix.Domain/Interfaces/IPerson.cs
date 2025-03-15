using CinemaFlix.Domain.Enums;
using CinemaFlix.Domain.ValueObjects;

namespace CinemaFlix.Domain.Interfaces;

public interface IPerson
{
    public Name Name { get; }
    public ushort Age { get; }
    public DateOnly BirthDate { get; }
    public EGender Gender { get; }
}