using System;
using SharedKernel.Domain;

namespace SharedKernel.Models
{
    public class RatingTvShow : BaseEntity<Guid>, IRating
    {
        public Guid TvShowId { get; set; }
        public TvShow TvShow { get; set; }
        public Rating Rating { get; set; }
        public Guid RatingId { get; set; }
    }
}