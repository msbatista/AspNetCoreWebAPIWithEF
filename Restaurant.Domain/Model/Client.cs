using Restaurant.Domain.Model.Addresses;

namespace Restaurant.Domain.Model
{
    public class Client
    {
        public long Id { get; set; }
        public long Cpf { get; set; }
        public string PhoneNumber { get; set; }
        public virtual AddressCollection Addresses { get; set; }
        public long AccountId { get; set; }
        public virtual Account Account { get; set; }
    }
}
