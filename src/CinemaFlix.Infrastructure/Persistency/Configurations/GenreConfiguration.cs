using CinemaFlix.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CinemaFlix.Infrastructure.Persistency.Configurations
{
    public class GenreConfiguration : BaseEntityConfiguration<Genre>
    {
        public override void Configure(EntityTypeBuilder<Genre> builder)
        {
            base.Configure(builder);

            builder.Property(g => g.Name)
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(g => g.Description)
                .HasMaxLength(500)
                .IsRequired(false);

            builder.HasMany(g => g.Movies)
                .WithMany(m => m.Genres);
        }
    }
}