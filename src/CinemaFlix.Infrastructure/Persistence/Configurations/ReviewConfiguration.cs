using CinemaFlix.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CinemaFlix.Infrastructure.Persistence.Configurations;

public class ReviewConfiguration : EntityTypeConfiguration<Review>
{
    public override void Configure(EntityTypeBuilder<Review> builder)
    {
        base.Configure(builder);
        
        builder.Property(r => r.Rating).HasColumnType("numeric(3,1)").IsRequired();
        builder.Property(r => r.Description).HasMaxLength(2000);
        builder.HasOne(r => r.Movie).WithMany().IsRequired();
    }
}