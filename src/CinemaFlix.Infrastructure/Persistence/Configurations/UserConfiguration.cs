using CinemaFlix.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CinemaFlix.Infrastructure.Persistence.Configurations;

public class UserConfiguration : EntityTypeConfiguration<User>
{
    public override void Configure(EntityTypeBuilder<User> builder)
    {
        base.Configure(builder);

        builder.Property(u => u.Password).IsRequired();
        builder.Property(u => u.Role).IsRequired();
        builder.Property(u => u.FavoriteMoviesIds);
        builder.Property(u => u.MoviesWatchListIds);
        builder.HasMany(u => u.Reviews).WithOne(r => r.User);
        builder.ComplexProperty(a => a.Name).Property(name => name.FirstName).IsRequired();
        builder.ComplexProperty(a => a.Name).Property(name => name.LastName).IsRequired();
        builder.ComplexProperty(m => m.Email)
            .Property(email => email.Address)
            .HasColumnName("EmailAddress")
            .IsRequired();
    }
}