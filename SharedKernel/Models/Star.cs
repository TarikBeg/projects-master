using System;
using System.Collections.Generic;
using SharedKernel.Domain;

namespace SharedKernel.Models
{
    public class Star : ValueObject<Star>
    {
        public static Star Default = new(0);

        public Star(int count)
        {
            Count = count;
        }

        public int Count { get; set; }

        protected override IEnumerable<object> EqualityCheckAttributes => new object[] {Count};

        public static Star Parse(int value)
        {
            if (value == 0) return Default;

            return new Star(value);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals(obj);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(base.GetHashCode(), Count);
        }

        public override string ToString()
        {
            return Count.ToString();
        }
    }
}