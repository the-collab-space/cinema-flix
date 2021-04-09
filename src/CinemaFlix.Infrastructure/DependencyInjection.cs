using CinemaFlix.Application.Common.Interfaces;
using CinemaFlix.Infrastructure.Persistence;
using CinemaFlix.Infrastructure.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CinemaFlix.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(
            this IServiceCollection services,
            IConfiguration configuration,
            IHostEnvironment hostEnvironment)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(hostEnvironment.ContentRootPath)
                .AddJsonFile("appsettings.json", true, true)
                .AddJsonFile($"appsettings.{hostEnvironment.EnvironmentName}.json", true, true)
                .AddEnvironmentVariables();

            if (hostEnvironment.IsDevelopment())
            {
                builder.AddUserSecrets("aspnet-CinemaFlix.UI-381D85A0-FECB-4FE1-8259-7D3CEDCA527E");
            }

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseNpgsql(builder.Build().GetConnectionString("DefaultConnection")));

            services.AddScoped<ApplicationDbContext>();

            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

            return services;
        }
    }
}
