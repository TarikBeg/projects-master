using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using MistralTask.Business.Queries;
using Repository.Repositories;
using SharedKernel.ApiModels;
using SharedKernel.ViewModels;

namespace MistralTask.Business.Handlers
{
    public class GetMoviesCommandHandler : IRequestHandler<GetMovies.Query, ApiModel<IReadOnlyList<MovieViewModel>>>
    {
        private readonly IMovieRepository _movieRepository;

        public GetMoviesCommandHandler(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public async Task<ApiModel<IReadOnlyList<MovieViewModel>>> Handle(GetMovies.Query query,
            CancellationToken cancellationToken)
        {
            var moviesSummary = await
                _movieRepository.GetMovies(query.Keyword, new PagingInfo(query.Page, query.PageSize), cancellationToken);

            return ApiModel<IReadOnlyList<MovieViewModel>>.Success().WithData(moviesSummary.MovieViewModels)
                .WithMeta(moviesSummary.PaginationInfo);
        }
    }
}