using System;
using System.Collections.Generic;
using System.Linq;

namespace SharedKernel.Models
{
    public interface IMovieShow<T> where T : IRating
    {
        public string Title { get; set; }
        public double AverageRating { get; set; }
        public string Description { get; set; }
        public DateTime ReleaseDate { get; set; }
        public ICollection<T> Ratings { get; set; }

        public double GetAverage()
        {
            return Ratings.Average(r => r.Rating.Star.Count);
        }
    }
}