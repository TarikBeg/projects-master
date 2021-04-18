using System;
using System.Collections.Generic;
using SharedKernel.Domain;

namespace SharedKernel.Models
{
    public class Cast : BaseEntity<Guid>
    {
        public CastMovie CastMovie { get; set; }
        public CastTvShow CastTvShow { get; set; }

        public ICollection<CastActor> CastActors { get; set; }
    }
}