using CinemaFlix.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CinemaFlix.Infrastructure.Persistence.Configurations
{
    public class UserConfiguration : BaseEntityConfiguration<User>
    {
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            base.Configure(builder);

            builder.OwnsOne(u => u.Email)
                .Property(x => x.Address)
                .HasMaxLength(300)
                .HasColumnName("Email"); ;

            builder.OwnsOne(u => u.Name)
                .Property(x => x.FirstName)
                .HasMaxLength(250)
                .HasColumnName("FirstName");

            builder.OwnsOne(u => u.Name)
                .Property(x => x.LastName)
                .HasMaxLength(150)
                .HasColumnName("LastName");

            builder.Property(u => u.CreationDate)
                .IsRequired(false);
        }
    }
}