using System.Threading;
using System.Threading.Tasks;
using SharedKernel.ApiModels;
using SharedKernel.ViewModels;

namespace Repository.Repositories
{
    public interface ITvShowRepository
    {
        Task<TvShowSummaryViewModel> GetTvShows(string keyword, PagingInfo pagingInfo,
            CancellationToken cancellationToken = default);

        //Task GetTvShowById(Guid commandTvShowId, CancellationToken cancellationToken = default);
    }
}