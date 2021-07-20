using Restaurant.Domain.Model.Orders;
using Restaurant.Domain.Model.ValueObjects;

namespace Restaurant.Domain.Model
{
    public interface IAccount
    {
        void AddOrder(Order order);
        bool IsDeleteAccountAllowed();
        Money GetTotalDebit();
    }
}
