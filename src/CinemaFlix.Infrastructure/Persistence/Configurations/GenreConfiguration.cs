using CinemaFlix.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CinemaFlix.Infrastructure.Persistence.Configurations
{
    public class GenreConfiguration : BaseEntityConfiguration<Genre>
    {
        public override void Configure(EntityTypeBuilder<Genre> builder)
        {
            base.Configure(builder);

            builder.Property(g => g.Type)
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(g => g.Description)
                .HasMaxLength(500)
                .IsRequired(false);
        }
    }
}