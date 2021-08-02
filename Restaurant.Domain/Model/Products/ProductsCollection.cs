using Restaurant.Domain.Model.ValueObjects;
using System.Collections.Generic;
using System.Linq;

namespace Restaurant.Domain.Model.Products
{
    public sealed class ProductsCollection : List<Product>
    {
        public Money GetTotalPrice()
        {
            if (Count == 0)
            {
                return new Money(0, new Currency(string.Empty));
            }

            Money total = new(0, this.First().Amount.Currency);

            return this.Aggregate(total, (current, product) =>
            {
                return new Money(current.Amount + product.Amount.Amount, current.Currency);
            });
        }
    }
}
