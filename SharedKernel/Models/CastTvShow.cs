using System;
using SharedKernel.Domain;

namespace SharedKernel.Models
{
    public class CastTvShow : BaseEntity<Guid>
    {
        public Guid TvShowId { get; set; }
        public TvShow TvShow { get; set; }
        public Cast Cast { get; set; }
        public Guid CastId { get; set; }
    }
}