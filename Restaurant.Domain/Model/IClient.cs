using Restaurant.Domain.Model.Addresses;

namespace Restaurant.Domain.Model
{
    public interface IClient
    {
        void AddAddress(Address address);
    }
}
