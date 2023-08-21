using Investments.Catalog.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Investments.Catalog.Infrastructure.Data.Mappings;

public class QuoteMap : IEntityTypeConfiguration<Quote>
{
    public void Configure(EntityTypeBuilder<Quote> builder)
    {
        builder.ToTable("Quotes");

        builder.Property(quote => quote.Value)
            .HasMaxLength(20)
            .HasPrecision(10);

        builder.Property(quote => quote.Date);

        builder.HasOne(quote => quote.Product)
            .WithMany(product => product.Quotes)
            .HasForeignKey(quote => quote.ProductId);
        
        builder.HasIndex(quote => new { quote.ProductId, quote.Date });
    }
}