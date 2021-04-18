using System;

namespace SharedKernel.Models
{
    public interface IRating
    {
        public Rating Rating { get; set; }
        public Guid RatingId { get; set; }
    }
}