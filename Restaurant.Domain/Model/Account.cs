using Restaurant.Domain.Model.Orders;
using Restaurant.Domain.Model.ValueObjects;
using System;

namespace Restaurant.Domain.Model
{
    public class Account : IAccount
    {
        public long Id { get; set; }
       // public long ClientId { get; set; }
        public DateTime CreationDate { get; }
        // public virtual Client Client { get; set; }
        public virtual OrdersCollection Orders { get; set; }

        public void AddOrder(Order order)
        {
            Orders.Add(order);
        }

        public Money GetTotalDebit()
        {
            return Orders.GetTotalDebit();
        }

        public bool IsDeleteAccountAllowed()
        {
            return GetTotalDebit().IsZero();
        }
    }
}
