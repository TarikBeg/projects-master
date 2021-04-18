using System;
using SharedKernel.Domain;

namespace SharedKernel.Models
{
    public class CastActor : BaseEntity<Guid>
    {
        public Guid ActorId { get; set; }
        public Actor Actor { get; set; }
        public Guid CastId { get; set; }
        public Cast Cast { get; set; }
    }
}