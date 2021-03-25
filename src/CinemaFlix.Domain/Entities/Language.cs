using CinemaFlix.Domain.Common;
using System;

namespace CinemaFlix.Domain.Entities
{
    public class Language : Entity
    {
        public string Name { get; set; }
        public string Iso_639_1 { get; set; }
    }
}
