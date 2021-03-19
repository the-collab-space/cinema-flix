using Microsoft.EntityFrameworkCore;
using CinemaFlix.Domain.Common;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CinemaFlix.Infrastructure.Persistency.Configurations
{
    public class BaseEntityConfiguration<T> : IEntityTypeConfiguration<T> where T : Entity
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            // Alternative Code 
            // builder.Property(p => p.Id).ValueGeneratedOnAdd()
            
            builder.HasKey(p => p.Id);
        }
    }
}
