using Restaurant.Domain.Model.Addresses;

namespace Restaurant.Domain.Model
{
    public class Client : IClient
    {
        public long Id { get; set; }
        public long Cpf { get; set; }
        public string PhoneNumber { get; set; }
        public virtual AddressCollection Addresses { get; } = new AddressCollection();
        public long AccountId { get; set; }
        public virtual Account Account { get; set; }

        public void AddAddress(Address address)
        {
            Addresses.Add(address);
        }
    }
}
