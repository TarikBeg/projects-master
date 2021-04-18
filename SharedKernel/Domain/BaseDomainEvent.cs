using System;

namespace SharedKernel.Domain
{
    public class BaseDomainEvent : IDomainEvent
    {
        public DateTime DateOccurred { get; protected set; } = DateTime.UtcNow;
    }
}