using System;
using SharedKernel.Domain;

namespace SharedKernel.Models
{
    public class Rating : BaseEntity<Guid>
    {
        public Rating()
        {
            Id = new Guid();
        }

        public Rating(int stars)
        {
            Star = new Star(stars);
        }

        public Star Star { get; set; }

        //public Guid UserId { get; set; }
        public RatingMovie RatingMovie { get; set; }
        public RatingTvShow RatingTvShow { get; set; }
    }
}