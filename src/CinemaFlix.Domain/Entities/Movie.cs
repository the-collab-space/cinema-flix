using CinemaFlix.Domain.Common;
using System;
using System.Collections.Generic;

namespace CinemaFlix.Domain.Entities
{
    public class Movie : Entity
    {
        public string Title { get; private set; }
        public string Synopsis { get; private set; }
        public string Description { get; private set; }
        public float? Rating { get; private set; }
        public DateTime? ReleaseDate { get; private set; }
        public TimeSpan? Duration { get; private set; }
        public DateTime? Announcement { get; private set; }
        public ICollection<Character> Characters { get; private set; } = new List<Character>();
        public ICollection<Actor> Actors { get; private set; } = new List<Actor>();
        public ICollection<Genre> Genres { get; private set; } = new List<Genre>();
        public ICollection<Language> Languages { get; private set; } = new List<Language>();
        public ICollection<Picture> Pictures { get; private set; } = new List<Picture>();
        public ICollection<Director> Directors { get; private set; } = new List<Director>();
    }
}