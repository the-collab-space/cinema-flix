using CinemaFlix.Domain.Common;
using System;
using System.Collections.Generic;

namespace CinemaFlix.Domain.Entities
{
    public class User : Entity
    {
        public string Name { get; set; }
        public List<Movie> Movies { get; set; } = new List<Movie>();
        public string Email { get; set; }
        public DateTime? CreationDate { get; set; }
    }
}
