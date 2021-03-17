using System;

namespace CinemaFlix.Domain.Entities
{
    public class Character
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
