using System;
using System.Collections.Generic;
using SharedKernel.Domain;

namespace SharedKernel.Models
{
    public sealed class Movie : AggregateRoot<Guid>, IMovieShow<RatingMovie>
    {
        public Movie()
        {
            Id = new Guid();
        }

        public Movie(string title, DateTime releaseDate, string coverImage, string description)
        {
            Title = title;
            ReleaseDate = releaseDate;
            CoverImage = coverImage;
            Description = description;
        }

        public string CoverImage { get; set; }
        public CastMovie CastMovie { get; set; }
        public double AverageRating { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Description { get; set; }

        public ICollection<RatingMovie> Ratings { get; set; }
    }
}