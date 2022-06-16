using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Config
{
    public class PlaceConfiguration : IEntityTypeConfiguration<Place>
    {
        public void Configure(EntityTypeBuilder<Place> builder)
        {
            builder.Property(p => p.IdCountry).IsRequired();
            builder.Property(p => p.Name).IsRequired().HasMaxLength(100);
            builder.Property(p => p.Description).IsRequired().HasMaxLength(300);
            builder.Property(p => p.ImageUrl).IsRequired().HasMaxLength(150);
            builder.Property(p => p.ApproximateExpenses).HasColumnType("decimal(6,2)");
            builder.HasOne(p => p.Category).WithMany(c => c.Places).HasForeignKey(p => p.IdCategory);
            builder.HasOne(p => p.Country).WithMany(c => c.Places).HasForeignKey(p => p.IdCountry);
        }
    }
}
