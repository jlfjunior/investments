using Investments.Catalog.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Investments.Catalog.Infrastructure.Data.Mappings;

public class ProductMap : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.ToTable("Products");
        
        builder.Property(product => product.Name)
            .HasMaxLength(100);
        
        builder.Property(product => product.Symbol)
            .HasMaxLength(10);
    }
}