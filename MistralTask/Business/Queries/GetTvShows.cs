using System.Collections.Generic;
using SharedKernel.ApiModels;
using SharedKernel.ViewModels;

namespace MistralTask.Business.Queries
{
    public class GetTvShows
    {
        public class Query : PaginationQuery<ApiModel<IReadOnlyList<TvShowViewModel>>>
        {
            public Query()
            {
            }

            public Query(int page, int pageSize, string keyword) : base(page, pageSize)
            {
                Keyword = keyword;
            }

            public string Keyword { get; set; }
        }
    }
}