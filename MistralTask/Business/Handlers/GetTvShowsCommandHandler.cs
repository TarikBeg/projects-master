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
    public class GetTvShowsCommandHandler : IRequestHandler<GetTvShows.Query, ApiModel<IReadOnlyList<TvShowViewModel>>>
    {
        private readonly ITvShowRepository _tvShowRepository;

        public GetTvShowsCommandHandler(ITvShowRepository tvShowRepository)
        {
            _tvShowRepository = tvShowRepository;
        }

        public async Task<ApiModel<IReadOnlyList<TvShowViewModel>>> Handle(GetTvShows.Query query,
            CancellationToken cancellationToken)
        {
            var tvShowSummaryViewModel = await
                _tvShowRepository.GetTvShows(query.Keyword, new PagingInfo(query.Page, query.PageSize),
                    cancellationToken);

            return ApiModel<IReadOnlyList<TvShowViewModel>>.Success().WithData(tvShowSummaryViewModel.TvShowViewModels)
                .WithMeta(tvShowSummaryViewModel.PaginationInfo);
        }
    }
}