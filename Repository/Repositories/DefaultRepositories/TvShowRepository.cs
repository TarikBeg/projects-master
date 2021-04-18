using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    public class TvShowRepository : ITvShowRepository
    {
        private readonly CoreDbContext _coreDbContext;
        private readonly IMapper _mapper;

        public TvShowRepository(IMapper mapper, CoreDbContext coreDbContext)
        {
            _mapper = mapper;
            _coreDbContext = coreDbContext;
        }

        public async Task<TvShowSummaryViewModel> GetTvShows(string keyword, PagingInfo pagingInfo,
            CancellationToken cancellationToken = default)
        {
            var tvShowsQuery = _coreDbContext.TvShows.AsQueryable();

            if (!string.IsNullOrEmpty(keyword))
            {
                tvShowsQuery = tvShowsQuery.SearchByPhrase<TvShow, RatingTvShow>(keyword);
            }

            tvShowsQuery = tvShowsQuery.OrderBy(x => x.AverageRating);

            var tvShows = await tvShowsQuery
                .SkipAndTake(pagingInfo)
                .ProjectTo<TvShowViewModel>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);

            return new TvShowSummaryViewModel
            {
                TvShowViewModels = tvShows,
                PaginationInfo = new PaginationInfo { Page = pagingInfo.PageNumber, PageSize = pagingInfo.PageSize, Total = tvShowsQuery.Count() }
            };
        }
    }
}
