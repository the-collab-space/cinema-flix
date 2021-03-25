using CinemaFlix.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CinemaFlix.Infrastructure.Persistence.Configurations
{
    public class UserConfiguration : BaseEntityConfiguration<User>
    {
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            base.Configure(builder);

            builder.Property(u => u.Email)
                .HasMaxLength(300)
                .IsRequired();

            builder.Property(u => u.Name)
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(u => u.CreationDate)
                .IsRequired(false);
        }
    }
}