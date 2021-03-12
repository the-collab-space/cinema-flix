using System;
using System.Collections.Generic;

namespace CinemaFlix.Domain.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<Movie> movies { get; set; } = new List<Movie>();
        public string Email { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
