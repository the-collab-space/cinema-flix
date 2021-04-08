using CinemaFlix.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CinemaFlix.Infrastructure.Persistence.Configurations
{
    public class CharacterConfiguration : BaseEntityConfiguration<Character>
    {
        public override void Configure(EntityTypeBuilder<Character> builder)
        {
            base.Configure(builder);

            builder.OwnsOne(u => u.Name)
                .Property(x => x.FirstName)
                .HasMaxLength(250)
                .HasColumnName("FirstName");

            builder.OwnsOne(u => u.Name)
                .Property(x => x.LastName)
                .HasMaxLength(150)
                .HasColumnName("LastName");

            builder.Property(c => c.Description)
                .HasMaxLength(500)
                .IsRequired(false);
        }
    }
}