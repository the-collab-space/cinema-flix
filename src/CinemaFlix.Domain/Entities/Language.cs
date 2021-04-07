using CinemaFlix.Domain.Common;
using System;

namespace CinemaFlix.Domain.Entities
{
    public class Language : Entity
    {
        public string Name { get; private set; }
        public string Code { get; private set; }
    }
}
