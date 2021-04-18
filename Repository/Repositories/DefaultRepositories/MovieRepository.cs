using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using Repository.Contexts;
using SharedKernel.ApiModels;
using SharedKernel.Extensions;
using SharedKernel.Models;
using SharedKernel.ViewModels;

namespace Repository.Repositories.DefaultRepositories
{
    public class MovieRepository : IMovieRepository
    {
        private readonly CoreDbContext _coreDbContext;
        private readonly IMapper _mapper;

        public MovieRepository(IMapper mapper, CoreDbContext coreDbContext)
        {
            _mapper = mapper;
            _coreDbContext = coreDbContext;
        }

        public async Task<MovieSummaryViewModel> GetMovies(string keyword, PagingInfo pagingInfo,
            CancellationToken cancellationToken = default)
        {
            var movieQuery = _coreDbContext.Movies
                .Include(x => x.CastMovie)
                .ThenInclude(x => x.Cast)
                .ThenInclude(x => x.CastActors)
                .ThenInclude(x => x.Actor)
                .Include(x => x.Ratings)
                .ThenInclude(x => x.Rating).AsQueryable();

            if (!string.IsNullOrEmpty(keyword) && keyword.Length >= 2)
                movieQuery = movieQuery.SearchByPhrase<Movie, RatingMovie>(keyword);

            movieQuery = movieQuery.OrderByDescending(x => x.AverageRating);
           
            var movies = await movieQuery
                .SkipAndTake(pagingInfo)
                .ProjectTo<MovieViewModel>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);

            return new MovieSummaryViewModel
            {
                MovieViewModels = movies,
                PaginationInfo = new PaginationInfo
                { Page = pagingInfo.PageNumber, PageSize = pagingInfo.PageSize, Total = movieQuery.Count() }
            };
        }

        public async Task AddStartForMovie(int stars, Movie movie, CancellationToken cancellationToken = default)
        {
            var rating = new Rating(stars);
            
            await _coreDbContext.Ratings.AddAsync(rating, cancellationToken);

            var ratingMovie = new RatingMovie(movie.Id, rating.Id);

            await _coreDbContext.RatingMovies.AddAsync(ratingMovie, cancellationToken);

            await _coreDbContext.SaveChangesAsync(cancellationToken);
        }

        public async Task UpdateMovie(Movie movie, CancellationToken cancellationToken = default)
        {
            movie.AverageRating = movie.Ratings.Average(x => x.Rating.Star.Count);

            _coreDbContext.Movies.Update(movie);

            await _coreDbContext.SaveChangesAsync(cancellationToken);
        }

        public async Task<Movie> GetMovieById(Guid movieId, CancellationToken cancellationToken)
        {
            var movie = await _coreDbContext.Movies
                .Include(x=>x.Ratings)
                .ThenInclude(x=>x.Rating)
                .FirstOrDefaultAsync(x => x.Id == movieId, cancellationToken);

            return movie;
        }
    }
}