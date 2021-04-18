using System.Collections.Generic;
using SharedKernel.ApiModels;

namespace SharedKernel.ViewModels
{
    public class TvShowSummaryViewModel
    {
        public IReadOnlyList<TvShowViewModel> TvShowViewModels { get; set; }
        public PaginationInfo PaginationInfo { get; set; }
    }
}