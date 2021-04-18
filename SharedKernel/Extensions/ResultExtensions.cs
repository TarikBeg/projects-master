using Microsoft.AspNetCore.Mvc;
using SharedKernel.ApiModels;

namespace SharedKernel.Extensions
{
    public static class ResultExtensions
    {
        public static ObjectResult ToActionResult<T>(this ApiModel<T> result)
        {
            return new(result) {StatusCode = (int) result.HttpStatusCode};
        }

        public static ObjectResult ToActionResult(this ApiModel result)
        {
            return new(result) {StatusCode = (int) result.HttpStatusCode};
        }
    }
}