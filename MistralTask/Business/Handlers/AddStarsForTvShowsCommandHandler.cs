using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using MistralTask.Business.Commands;
using Repository.Repositories;
using SharedKernel.ApiModels;

namespace MistralTask.Business.Handlers
{
    public class AddStarsForTvShowsCommandHandler : IRequestHandler<AddStarsForTvShow.Command, ApiModel>
    {
        private readonly ITvShowRepository _tvShowRepository;

        public AddStarsForTvShowsCommandHandler(ITvShowRepository tvShowRepository)
        {
            _tvShowRepository = tvShowRepository;
        }

        public async Task<ApiModel> Handle(AddStarsForTvShow.Command command, CancellationToken cancellationToken)
        {
            //var movie = await _tvShowRepository.GetTvShowById(command.TvShowId, cancellationToken);

            //if (movie == null)
            //{
            //    throw new Exception($"Movie with id: {command.MovieId} doesn't exist");
            //}

            //await _tvShowRepository.AddStartForTvShow(command.Stars, movie, cancellationToken);

            return ApiModel.Success();
        }
    }
}