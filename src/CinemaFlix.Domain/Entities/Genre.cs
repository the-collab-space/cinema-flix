using CinemaFlix.Domain.Common;
using System.Collections.Generic;

namespace CinemaFlix.Domain.Entities
{
    public class Genre : Entity
    {
        public string Type { get; private set; }
        public string Description { get; private set; }
        public ICollection<Movie> Movies { get; private set; } = new List<Movie>();
    }
}