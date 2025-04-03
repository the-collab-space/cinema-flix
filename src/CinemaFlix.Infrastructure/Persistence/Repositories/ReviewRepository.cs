using CinemaFlix.Application.Common.Interfaces.Repositories;
using CinemaFlix.Domain.Entities;

namespace CinemaFlix.Infrastructure.Persistence.Repositories;

public class ReviewRepository : Repository<Review>, IReviewRepository
{
    public ReviewRepository(ApplicationDbContext context) : base(context)
    {
    }
}