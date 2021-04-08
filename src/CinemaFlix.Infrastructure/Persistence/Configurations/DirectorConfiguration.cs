using CinemaFlix.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CinemaFlix.Infrastructure.Persistence.Configurations
{
    public class DirectorConfiguration : BaseEntityConfiguration<Director>
    {
        public override void Configure(EntityTypeBuilder<Director> builder)
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

            builder.Property(d => d.Description)
                .HasMaxLength(500)
                .IsRequired(false);
        }
    }
}