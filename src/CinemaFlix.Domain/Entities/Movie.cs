using System;
using System.Collections.Generic;

namespace CinemaFlix.Domain.Entities
{
    public class Movie
    {
        
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Sinopse { get; set; }
        public string Description { get; set; }
        public float Rating { get; set; }
        public DateTime ReleaseDate { get; set; }
        public TimeSpan Duration { get; set; }
        public DateTime AnnouciamentDate { get; set; }
        public List<Character> Characters { get; set; }
        public List<Genre> Genres { get; set; }
        public List<Language> Idiomas { get; set; }
        public List<Picture> Gallery { get; set; }
        public List<Director> Directors { get; set; }

    }
}
