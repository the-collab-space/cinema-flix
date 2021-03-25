using CinemaFlix.Domain.Common;
using System;
using System.Collections.Generic;

namespace CinemaFlix.Domain.Entities
{
    public class Movie : Entity
    {
        public string Name { get; set; }
        public string Sinopse { get; set; }
        public string Description { get; set; }
        public float? Rating { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public TimeSpan? Duration { get; set; }
        public DateTime? AnnouciamentDate { get; set; }
        public ICollection<Character> Characters { get; set; } = new List<Character>();
        public ICollection<Actor> Actors { get; set; } = new List<Actor>();
        public ICollection<Genre> Genres { get; set; } = new List<Genre>();
        public ICollection<Language> Languages { get; set; } = new List<Language>();
        public ICollection<Picture> Pictures { get; set; } = new List<Picture>();
        public ICollection<Director> Directors { get; set; } = new List<Director>();

    }
}
