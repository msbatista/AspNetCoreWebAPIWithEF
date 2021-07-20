using System;

namespace Restaurant.Domain.Model.ValueObjects
{
    public readonly struct Currency : IEquatable<Currency>
    {
        public string Code { get; }

        public Currency(string code)
        {
            Code = code;
        }

        public static readonly Currency Real = new("BRL");
        public static readonly Currency Dollar = new("USD");

        public override bool Equals(object obj)
        {
            return obj is Currency currency && Equals(currency);
        }

        public bool Equals(Currency other)
        {
            return Code == other.Code;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Code);
        }

        public static bool operator ==(Currency left, Currency right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Currency left, Currency right)
        {
            return !(left == right);
        }
    }
}
