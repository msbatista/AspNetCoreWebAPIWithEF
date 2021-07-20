using System;

namespace Restaurant.Domain.Model.ValueObjects
{
    public readonly struct Money : IEquatable<Money>
    {
        public double Amount { get; }
        public Currency Currency { get; }

        public Money(double amount, Currency currency)
        {
            Amount = amount;
            Currency = currency;
        }

        public bool IsZero()
        {
            return Amount == 0;
        }

        public override bool Equals(object obj)
        {
            return obj is Money price && Equals(price);
        }

        public bool Equals(Money other)
        {
            return Amount == other.Amount &&
                   Currency.Equals(other.Currency);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Amount, Currency);
        }

        public static bool operator ==(Money left, Money right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Money left, Money right)
        {
            return !(left == right);
        }
    }
}
