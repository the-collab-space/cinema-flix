using CinemaFlix.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaFlix.Infrastructure.Persistence.Configurations
{
    public class ActorConfiguration : BaseEntityConfiguration<Actor>
    {
        public override void Configure(EntityTypeBuilder<Actor> builder)
        {
            base.Configure(builder);

            builder.Property(a => a.Name)
              .HasMaxLength(200)
              .IsRequired();

            builder.Property(a => a.Description)
               .HasMaxLength(500)
               .IsRequired(false);

            builder.Property(a => a.Gender)
               .IsRequired(false);

            builder.Property(a => a.Age)
               .IsRequired(false);

            builder.HasMany(a => a.Pictures)
                .WithOne(p => p.Actor);

            builder.HasMany(a => a.Movies)
                .WithMany(a => a.Actors);

            builder.HasMany(a => a.Characters)
                .WithMany(a => a.Actors);
        }
    }
}
