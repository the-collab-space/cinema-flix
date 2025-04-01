using CinemaFlix.Application.Common.Interfaces;
using CinemaFlix.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CinemaFlix.Infrastructure;

public static class InfrastructureDependency
{
    public static void AddInfrastructure(this IServiceCollection services ,IConfiguration configuration)
    {
        services.AddDbContext<IApplicationDbContext, ApplicationDbContext>(options =>
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection")
                                   ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

            options.UseNpgsql(connectionString, providerOptions =>
            {
                providerOptions.UseNodaTime();
                providerOptions.MigrationsHistoryTable("__ef_migrations_history");
                providerOptions.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName);
            });

            options.UseSnakeCaseNamingConvention();
        });
    }
}