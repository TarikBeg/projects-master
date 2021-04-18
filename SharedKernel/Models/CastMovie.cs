using System;
using SharedKernel.Domain;

namespace SharedKernel.Models
{
    public class CastMovie : BaseEntity<Guid>
    {
        public Guid MovieId { get; set; }
        public Movie Movie { get; set; }
        public Cast Cast { get; set; }
        public Guid CastId { get; set; }
    }
}