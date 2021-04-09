using CinemaFlix.Domain.Common;
using CinemaFlix.Domain.Enums;
using System.Collections.Generic;
using CinemaFlix.Domain.ValueObjects;

namespace CinemaFlix.Domain.Entities
{
    public class Actor : Entity
    {
        public Name Name { get; private set; }
        public string Description { get; private set; }
        public Gender? Gender { get; private set; }
        public int? Age { get; private set; }
        public ICollection<Movie> Movies { get; private set; } = new List<Movie>();
        public ICollection<Picture> Pictures { get; private set; } = new List<Picture>();
        public ICollection<Character> Characters { get; private set; } = new List<Character>();
    }
}
