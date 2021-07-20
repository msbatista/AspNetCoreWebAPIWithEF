using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Restaurant.Domain.Model.Orders;

namespace Restaurant.Infrastructure.DataAccess.EntityFrameworkConfiguration
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Orders");

            builder.HasKey(order => order.Id);

            builder.Property(order => order.AddressId).UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction).HasColumnType("BIGINT").IsRequired();
            builder.Property(order => order.TransactionDate).HasDefaultValueSql("GETDATE()");
            builder.Property(order => order.IsQuit).IsRequired().HasColumnType("BIT");
            builder.HasMany(order => order.Products).WithOne().IsRequired();
        }
    }
}
