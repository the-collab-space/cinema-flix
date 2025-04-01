using CinemaFlix.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CinemaFlix.Infrastructure.Persistence.Configurations;

public class MovieConfiguration : EntityTypeConfiguration<Movie>
{
    public override void Configure(EntityTypeBuilder<Movie> builder)
    {
        base.Configure(builder);
        builder.Property(m => m.Title).IsRequired();
        builder.Property(m => m.Synopsis).HasMaxLength(2000);
        builder.Property(m => m.Adult);
        builder.Property(m => m.Rating).HasColumnType("numeric(3,1)");
        builder.Property(m => m.ReleaseDate);
        builder.HasMany(m => m.Actors)
            .WithMany(a => a.Movies);
        builder.HasMany(m => m.Directors).WithMany(d => d.Movies);

        builder.OwnsMany(m => m.Genres).Property(g => g.Name).IsRequired();
    }
}