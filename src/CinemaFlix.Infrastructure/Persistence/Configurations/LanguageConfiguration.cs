using CinemaFlix.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CinemaFlix.Infrastructure.Persistence.Configurations
{
    public class LanguageConfiguration : BaseEntityConfiguration<Language>
    {
        public override void Configure(EntityTypeBuilder<Language> builder)
        {
            base.Configure(builder);

            builder.Property(l => l.Name)
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(l => l.Iso_639_1)
                .HasMaxLength(500)
                .IsRequired();
        }
    }
}