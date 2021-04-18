using System.Collections.Generic;

namespace SharedKernel.Domain
{
    public interface IHasDomainEvents
    {
        IReadOnlyList<BaseDomainEvent> DomainEvents { get; }
        void ClearDomainEvents();
    }
}
