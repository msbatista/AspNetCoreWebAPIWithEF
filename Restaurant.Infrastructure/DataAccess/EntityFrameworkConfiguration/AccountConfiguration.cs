using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Restaurant.Domain.Model;

namespace Restaurant.Infrastructure.DataAccess.EntityFrameworkConfiguration
{
    public class AccountConfiguration : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.ToTable("Accounts");

            builder.HasKey(account => account.Id);

            builder.Property(account => account.Id).IsRequired().HasColumnType("BIGINT").UseIdentityColumn();

            builder.Property(account => account.CreationDate).HasDefaultValueSql("GETDATE()");

            // builder.Property(account => account.ClientId).UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction).HasColumnType("BIGINT");

            builder.HasMany(account => account.Orders).WithOne().HasForeignKey("AccountId");

            // builder.HasOne(account => account.Client).WithOne(client => client.Account).HasForeignKey<Account>(account => account.ClientId);
        }
    }
}
