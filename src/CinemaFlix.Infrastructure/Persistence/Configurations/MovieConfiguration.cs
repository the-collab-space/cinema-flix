using CinemaFlix.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CinemaFlix.Infrastructure.Persistence.Configurations
{
    public class MovieConfiguration : BaseEntityConfiguration<Movie>
    {
        public override void Configure(EntityTypeBuilder<Movie> builder)
        {
            base.Configure(builder);

            builder.Property(t => t.Name)
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(t => t.Rating)
                 .HasColumnType("NUMERIC(2,1)")
                 .IsRequired(false);

            builder.Property(t => t.Sinopse)
                 .HasMaxLength(1000)
                 .IsRequired(false);

            builder.Property(t => t.Description)
               .HasMaxLength(500)
               .IsRequired(false);

            builder.Property(t => t.AnnouciamentDate)
               .IsRequired(false);

            builder.Property(t => t.Duration)
               .IsRequired(false);

            builder.Property(t => t.ReleaseDate)
                .IsRequired(false);

            builder.HasMany(p => p.Pictures)
                .WithOne(p => p.Movie)
                .HasForeignKey(m =>m.MovieId);

            builder.HasMany(p => p.Genres)
                .WithMany(p => p.Movies);

            builder.HasMany(p => p.Characters)
              .WithMany(p => p.Movies);

            builder.HasMany(p => p.Directors)
              .WithMany(p => p.Movies);

            builder.HasMany(m => m.Actors)
                .WithMany(m => m.Movies);

        }
    }
}
