using System;
using MediatR;
using SharedKernel.ApiModels;

namespace MistralTask.Business.Commands
{
    public class AddStarsForTvShow
    {
        public class Command : IRequest<ApiModel>
        {
            public int Stars { get; set; }
            public Guid TvShowId { get; set; }
        }
    }
}