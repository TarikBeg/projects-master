using System;
using System.Collections.Generic;
using System.Linq;

namespace SharedKernel.Domain
{
    public abstract class ValueObject<T> : IEquatable<ValueObject<T>>
        where T : ValueObject<T>
    {
        protected abstract IEnumerable<object> EqualityCheckAttributes { get; }

        public virtual bool Equals(ValueObject<T> other)
        {
            return other != null &&
                   GetType() == other.GetType() &&
                   EqualityCheckAttributes.SequenceEqual(other.EqualityCheckAttributes);
        }

        public override int GetHashCode()
        {
            return EqualityCheckAttributes
                .Aggregate(0, (hash, a) => hash = hash * 31 + (a?.GetHashCode() ?? 0));
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as ValueObject<T>);
        }

        public static bool operator ==(ValueObject<T> left, ValueObject<T> right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ValueObject<T> left, ValueObject<T> right)
        {
            return !Equals(left, right);
        }
    }
}