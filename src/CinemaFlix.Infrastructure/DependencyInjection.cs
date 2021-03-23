using CinemaFlix.Infrastructure.Persistency;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CinemaFlix.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection ConfigureDatabase(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));

            //TODO: CreateRepository Pattern
            //services.AddScoped(typeof(IRepository<>), typeof(EntityRepository<>));

            return services;
        }
    }
}
