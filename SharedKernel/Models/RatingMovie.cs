using System;
using SharedKernel.Domain;

namespace SharedKernel.Models
{
    public class RatingMovie : BaseEntity<Guid>, IRating
    {
        public RatingMovie()
        {
            Id = new Guid();
        }

        public RatingMovie(Guid movieId, Guid ratingId) : this()
        {
            MovieId = movieId;
            RatingId = ratingId;
        }

        public Guid MovieId { get; set; }
        public Movie Movie { get; set; }
        public Rating Rating { get; set; }
        public Guid RatingId { get; set; }
    }
}