using CinemaFlix.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CinemaFlix.Infrastructure.Persistence.Configurations;

public class ActorConfiguration : EntityTypeConfiguration<Actor>
{
    public override void Configure(EntityTypeBuilder<Actor> builder)
    {
        base.Configure(builder);

        builder.Property(a => a.BirthDate).IsRequired();
        builder.Property(a => a.Gender).IsRequired();
        builder.Property(a => a.Description).HasMaxLength(2000);

        builder.ComplexProperty(a => a.Name).Property(name => name.FirstName).IsRequired();
        builder.ComplexProperty(a => a.Name).Property(name => name.LastName).IsRequired();
    }
}