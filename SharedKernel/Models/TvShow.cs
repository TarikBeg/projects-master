using System;
using System.Collections.Generic;
using SharedKernel.Domain;

namespace SharedKernel.Models
{
    public class TvShow : AggregateRoot<Guid>, IMovieShow<RatingTvShow>
    {
        public TvShow()
        {
            Id = new Guid();
        }

        public TvShow(string title, DateTime releaseDate) : this()
        {
            Title = title;
            ReleaseDate = releaseDate;
        }

        public string CoverImage { get; set; }
        public CastTvShow CastTvShow { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public double AverageRating { get; set; }
        public string Description { get; set; }
        public ICollection<RatingTvShow> Ratings { get; set; }
    }
}