using System.Collections.Generic;
using SharedKernel.ApiModels;

namespace SharedKernel.ViewModels
{
    public class MovieSummaryViewModel
    {
        public IReadOnlyList<MovieViewModel> MovieViewModels { get; set; }
        public PaginationInfo PaginationInfo { get; set; }
    }
}