using CinemaFlix.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CinemaFlix.Infrastructure.Persistency.Configurations
{
    public class CharacterConfiguration : BaseEntityConfiguration<Character>
    {
        public override void Configure(EntityTypeBuilder<Character> builder)
        {
            base.Configure(builder);

            builder.Property(c => c.Name)
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(c => c.Description)
                .HasMaxLength(500)
                .IsRequired(false);
            
            builder.HasMany(c => c.Movies)
                .WithMany(m => m.Characters);

            builder.HasMany(c => c.Actors)
                .WithMany(a => a.Characters);
        }
    }
}