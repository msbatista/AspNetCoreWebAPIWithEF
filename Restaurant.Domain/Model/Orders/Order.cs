using Restaurant.Domain.Model.Addresses;
using Restaurant.Domain.Model.Products;
using System;

namespace Restaurant.Domain.Model.Orders
{
    public class Order
    {
        public long Id { get; set; }
        public DateTime TransactionDate { get; set; }
        public long AddressId { get; set; }
        public virtual ProductsCollection Products { get; set; }
        public bool IsQuit { get; set; }
        public virtual Address Address { get; set; }
    }
}
