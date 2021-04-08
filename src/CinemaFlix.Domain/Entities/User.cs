using CinemaFlix.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using CinemaFlix.Domain.ValueObjects;

namespace CinemaFlix.Domain.Entities
{
    public class User : Entity
    {
        private readonly IList<Movie> _movies;
        protected User() { }
        public User(Name name, Email email)
        {
            Name = name;
            Email = email;
            _movies = new List<Movie>();
        }
        public Name Name { get; private set; }
        public Email Email { get; private set; }
        public DateTime? CreationDate { get; private set; } = DateTime.Now;
        public IReadOnlyCollection<Movie> Movies => _movies.ToArray();

        public void AddMovie(Movie movie)
        {
            _movies.Add(movie);
        }
    }
}