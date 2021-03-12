using CinemaFlix.Domain.Enums;
using System;
using System.Collections.Generic;

namespace CinemaFlix.Domain.Entities
{
    public class Actor
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Gender Gender { get; set; }
        public int Age { get; set; }
        public List<Movie> Movies { get; set; } = new List<Movie>();
        public Picture Picture { get; set; }

    }
}
