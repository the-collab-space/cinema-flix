using CinemaFlix.Domain.Common;
using CinemaFlix.Domain.Enums;
using System;
using System.Collections.Generic;

namespace CinemaFlix.Domain.Entities
{
    public class Actor : Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Gender? Gender { get; set; }
        public int? Age { get; set; }
        public ICollection<Movie> Movies { get; set; } = new List<Movie>();
        public ICollection<Picture> Pictures { get; set; } = new List<Picture>();
        public ICollection<Character> Characters { get; set; } = new List<Character>();

    }
}
