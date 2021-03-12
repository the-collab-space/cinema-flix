using System;

namespace CinemaFlix.Domain.Entities
{
    public class Language
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Iso_639_1 { get; set; }
    }
}
