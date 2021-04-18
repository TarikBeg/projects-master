using System;
using System.Collections.Generic;
using SharedKernel.Domain;

namespace SharedKernel.Models
{
    public class Actor : BaseEntity<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        public ICollection<CastActor> CastActors { get; set; }
    }
}