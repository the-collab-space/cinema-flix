using System;

namespace CinemaFlix.Domain.Entities
{
    public class Picture
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool Thumbnail { get; set; }
        public int MyProperty { get; set; }
    }
}
