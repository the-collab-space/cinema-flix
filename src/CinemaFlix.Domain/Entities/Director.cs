using CinemaFlix.Domain.Common;
using System;
using System.Collections.Generic;

namespace CinemaFlix.Domain.Entities
{
    public class Director : Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Movie> Movies { get; set; } = new List<Movie>();
    }
}
