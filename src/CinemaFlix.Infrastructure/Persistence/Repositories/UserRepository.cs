using CinemaFlix.Application.Common.Interfaces.Repositories;
using CinemaFlix.Domain.Entities;

namespace CinemaFlix.Infrastructure.Persistence.Repositories;

public class UserRepository : Repository<User>, IUserRepository
{
    public UserRepository(ApplicationDbContext context) : base(context)
    {
    }
}