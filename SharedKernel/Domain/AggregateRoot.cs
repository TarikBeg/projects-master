using System;
using System.Collections.Generic;

namespace SharedKernel.Domain
{
    public class AggregateRoot<TEntityKey> : BaseEntity<TEntityKey>, IHasDomainEvents
        where TEntityKey : IEquatable<TEntityKey>
    {
        private readonly List<BaseDomainEvent> _domainEvents = new List<BaseDomainEvent>();

        public virtual IReadOnlyList<BaseDomainEvent> DomainEvents => _domainEvents;

        public void ClearDomainEvents()
        {
            _domainEvents?.Clear();
        }

        IReadOnlyList<BaseDomainEvent> IHasDomainEvents.DomainEvents => _domainEvents;

        public void AddDomainEvent(BaseDomainEvent eventItem)
        {
            _domainEvents.Add(eventItem);
        }

        public void RemoveDomainEvent(BaseDomainEvent eventItem)
        {
            _domainEvents?.Remove(eventItem);
        }
    }
}