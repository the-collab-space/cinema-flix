using CinemaFlix.Domain.Common;
using System;

namespace CinemaFlix.Domain.Entities
{
    public class Picture : Entity
    {
        public string Description { get; private set; }
        public bool? Thumbnail { get; private set; }
        public Movie Movie { get; private set; }
        public Guid? MovieId { get; private set; }
        public Actor Actor { get; private set; }
        public Guid? ActorId { get; private set; }
    }
}