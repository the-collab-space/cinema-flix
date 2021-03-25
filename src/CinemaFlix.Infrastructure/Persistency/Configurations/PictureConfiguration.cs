using CinemaFlix.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CinemaFlix.Infrastructure.Persistency.Configurations
{
    public class PictureConfiguration : BaseEntityConfiguration<Picture>
    {
        public override void Configure(EntityTypeBuilder<Picture> builder)
        {
            base.Configure(builder);

            builder.Property(p => p.Description)
                .HasMaxLength(500)
                .IsRequired(false);

            builder.Property(p => p.Thumbnail)
                .IsRequired(false);

            builder.HasOne(p => p.Actor)
                .WithMany(a => a.Pictures);
            
            builder.HasOne(p => p.Movie)
                .WithMany(m => m.Pictures);
        }
    }
}