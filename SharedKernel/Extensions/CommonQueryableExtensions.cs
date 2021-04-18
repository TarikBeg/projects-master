using System.Linq;
using SharedKernel.ApiModels;

namespace SharedKernel.Extensions
{
    public static class CommonQueryableExtensions
    {
        public static IQueryable<T> SkipAndTake<T>(this IQueryable<T> queryable, PagingInfo pagingInfo = null)
        {
            pagingInfo ??= new PagingInfo();
            return queryable.Skip(pagingInfo.SkipSize).Take(pagingInfo.PageSize);
        }
    }
}