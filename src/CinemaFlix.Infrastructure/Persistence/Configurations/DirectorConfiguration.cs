using CinemaFlix.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CinemaFlix.Infrastructure.Persistence.Configurations;

public class DirectorConfiguration : EntityTypeConfiguration<Director>
{
    public override void Configure(EntityTypeBuilder<Director> builder)
    {
        base.Configure(builder);

        builder.Property(d => d.BirthDate).IsRequired();
        builder.Property(d => d.Gender).IsRequired();
        builder.Property(d => d.Description).HasMaxLength(2000);
        builder.ComplexProperty(a => a.Name).Property(name => name.FirstName).IsRequired();
        builder.ComplexProperty(a => a.Name).Property(name => name.LastName).IsRequired();
    }
}