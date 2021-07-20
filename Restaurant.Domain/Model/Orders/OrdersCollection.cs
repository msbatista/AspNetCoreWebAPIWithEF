using Restaurant.Domain.Model.ValueObjects;
using System.Collections.Generic;
using System.Linq;

namespace Restaurant.Domain.Model.Orders
{
    public sealed class OrdersCollection : List<Order>
    {
        public Money GetTotalDebit()
        {
            if (this.Count == 0)
            {
                return new Money(0, new Currency(string.Empty));
            }

            if (this.Count == 0)
            {
                return new Money(0, new Currency(string.Empty));
            }

            Money total = new Money(0, this.First().Products.GetTotalPrice().Currency);

            return this.Aggregate(total, (current, order) =>
            {
                if (!order.IsQuit)
                {
                    return new Money(current.Amount + order.Products.GetTotalPrice().Amount, current.Currency);
                }
                else
                {
                    return new Money(0, current.Currency);
                }
            });
        }
    }
}
