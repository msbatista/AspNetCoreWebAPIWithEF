using Restaurant.Domain.Model.ValueObjects;

namespace Restaurant.Domain.Model.Products
{
    public class Product
    {

        public long Id { get; set; }
        public string Name { get; set; }
        public Money Amount { get; set; }
        public double Value { get => Amount.Amount; }
        public string Currency { get => Amount.Currency.Code; }

        public Product(long id, string name, double value, string currency)
        {
            Id = id;
            Name = name;
            Amount = new Money(value, new Currency(currency));
        }
    }
}
