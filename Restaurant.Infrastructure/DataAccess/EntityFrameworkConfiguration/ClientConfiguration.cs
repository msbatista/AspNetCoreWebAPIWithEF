using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Restaurant.Domain.Model;

namespace Restaurant.Infrastructure.DataAccess.EntityFrameworkConfiguration
{
    public class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.ToTable("Clients");

            builder.HasKey(client => client.Id);

            builder.Property(client => client.Id).IsRequired().HasColumnType("BIGINT").UseIdentityColumn();

            builder.Property(client => client.Cpf).IsRequired().HasColumnType("BIGINT");

            builder.Property(client => client.PhoneNumber).IsRequired().HasColumnType("VARCHAR(32)");

            builder.HasMany(client => client.Addresses).WithOne().HasForeignKey("ClientId");

            builder.HasOne(client => client.Account).WithOne(); // .WithOne(account => account.Client).HasForeignKey<Client>(client => client.AccountId);

            //builder.Property(client => client.AccountId).UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction).HasColumnType("BIGINT");
        }
    }
}
