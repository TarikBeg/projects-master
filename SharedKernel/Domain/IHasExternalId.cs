using System;

namespace SharedKernel.Domain
{
    public interface IHasExternalId
    {
        Guid ExternalId { get; set; }
    }
}