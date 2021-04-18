using System.Net;
using Newtonsoft.Json;

namespace SharedKernel.ApiModels
{
    public class ApiModel
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public PaginationInfo PaginationInfo { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string[] Errors { get; set; }

        [JsonIgnore] 
        public HttpStatusCode HttpStatusCode { get; set; }

        [JsonIgnore]
        public bool IsSuccess => HttpStatusCode >= (HttpStatusCode) 200 && HttpStatusCode <= (HttpStatusCode) 299;

        public new static ApiModel Success()
        {
            return new ApiModel
            {
                HttpStatusCode = HttpStatusCode.OK
            };
        }
    }

    public class ApiModel<TResult> : ApiModel
    {
        public ApiModel()
        {
        }

        public ApiModel(TResult records)
        {
            Records = records;
            HttpStatusCode = HttpStatusCode.OK;
        }

        public TResult Records { get; set; }

        public ApiModel<TResult> WithMeta<TEntity>(PaginationQuery<TEntity> meta, long total)
        {
            PaginationInfo = new PaginationInfo {PageSize = meta.PageSize, Page = meta.Page, Total = total};
            return this;
        }

        public ApiModel<TResult> WithMeta(PaginationInfo pagination)
        {
            PaginationInfo = pagination;
            return this;
        }

        public ApiModel<TResult> WithData(TResult result)
        {
            Records = result;
            return this;
        }

        public new static ApiModel<TResult> Success()
        {
            return new ApiModel<TResult>
            {
                HttpStatusCode = HttpStatusCode.OK
            };
        }

        public new static ApiModel<TResult> NotFound(params string[] messages)
        {
            return new ApiModel<TResult>
            {
                HttpStatusCode = HttpStatusCode.NotFound,
                Errors = messages
            };
        }
    }
}