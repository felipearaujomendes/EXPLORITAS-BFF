using Exploritas.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Exploritas.Infrastructure.Data.Mappings
{
    public class CotaMapping : IEntityTypeConfiguration<Cota>
    {
        public void Configure(EntityTypeBuilder<Cota> builder)
        {

            builder.Property(p => p.Id).HasColumnName("internal_entity_id");
            builder.Property(p => p.Nav).HasColumnName("nav");
            builder.Property(p => p.Share).HasColumnName("share");
            builder.Property(p => p.NavAndShareId).HasColumnName("nav_and_share_id");
            builder.Property(p => p.Data).HasColumnName("reference_date");
            
            builder.ToTable("nav_and_share");
        }
    }
}
