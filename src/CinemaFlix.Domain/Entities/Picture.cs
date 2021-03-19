using CinemaFlix.Domain.Common;
using System;

namespace CinemaFlix.Domain.Entities
{
    public class Picture : Entity
    {
        public string Name { get; set; }
        public bool? Thumbnail { get; set; }
        public Movie Movie { get; set; }
        public Guid MovieId { get; set; }
        public Actor Actor { get; set; }
    }
}
