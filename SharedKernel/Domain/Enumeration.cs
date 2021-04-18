using System;

namespace SharedKernel.Domain
{
    public class Enumeration : IComparable
    {
        protected Enumeration()
        {
        }

        protected Enumeration(string name, int id)
        {
            Id = id;
            Name = name;
        }

        public string Name { get; private set; }
        public int Id { get; private set; }

        public int CompareTo(object other)
        {
            return Id.CompareTo(((Enumeration) other).Id);
        }

        public override string ToString()
        {
            return Name;
        }

        public override bool Equals(object obj)
        {
            var otherValue = obj as Enumeration;

            if (otherValue == null)
                return false;

            var typeMatches = GetType() == obj.GetType();
            var valueMatches = Id.Equals(otherValue.Id);

            return typeMatches && valueMatches;
        }

        protected bool Equals(Enumeration other)
        {
            return Name == other?.Name && Id == other?.Id;
        }

        public static bool operator ==(Enumeration left, Enumeration right)
        {
            return left is not null && (ReferenceEquals(left, right) || left.Equals(right));
        }

        public static bool operator !=(Enumeration left, Enumeration right)
        {
            return !(left == right);
        }
    }
}