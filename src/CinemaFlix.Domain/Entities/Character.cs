using CinemaFlix.Domain.Common;
using System.Collections.Generic;
using CinemaFlix.Domain.ValueObjects;

namespace CinemaFlix.Domain.Entities
{
    public class Character : Entity
    {
        public Name Name { get; private set; }
        public string Description { get; private set; }
        public ICollection<Movie> Movies { get; private set; } = new List<Movie>();
        public ICollection<Actor> Actors { get; private set; } = new List<Actor>();
    }
}
