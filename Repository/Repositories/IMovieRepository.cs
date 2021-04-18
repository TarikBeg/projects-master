using System;
using System.Threading;
using System.Threading.Tasks;
using SharedKernel.ApiModels;
using SharedKernel.Models;
using SharedKernel.ViewModels;

namespace Repository.Repositories
{
    public interface IMovieRepository
    {
        Task<MovieSummaryViewModel> GetMovies(string keyword, PagingInfo pagingInfo,
            CancellationToken cancellationToken = default);
        Task AddStartForMovie(int stars, Movie movie,
            CancellationToken cancellationToken = default);
        Task<Movie> GetMovieById(Guid movieId, CancellationToken cancellationToken);
        Task UpdateMovie(Movie movie, CancellationToken cancellationToken = default);
    }
}