using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Restaurant.Domain.Model.Products;

namespace Restaurant.Infrastructure.DataAccess.EntityFrameworkConfiguration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");

            builder.HasKey(product => product.Id);

            builder.Property(product => product.Id).IsRequired().HasColumnType("BIGINT").UseIdentityColumn();

            builder.Property(product => product.Name).IsRequired().HasColumnType("VARCHAR(255)");

            builder.Ignore(product => product.Amount);

            builder.Property(product => product.Currency).IsRequired();

            builder.Property(product => product.Value).IsRequired();
        }
    }
}
