using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using MistralTask.Business.Commands;
using Repository.Repositories;
using SharedKernel.ApiModels;

namespace MistralTask.Business.Handlers
{
    public class AddStarsForMovieCommandHandler : IRequestHandler<AddStarsForMovie.Command, ApiModel>
    {
        private readonly IMovieRepository _movieRepository;

        public AddStarsForMovieCommandHandler(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public async Task<ApiModel> Handle(AddStarsForMovie.Command command, CancellationToken cancellationToken)
        {
            var movie = await _movieRepository.GetMovieById(command.MovieId, cancellationToken);

            if (movie == null)
            {
                throw new Exception($"Movie with id: {command.MovieId} doesn't exist");
            }

            await _movieRepository.AddStartForMovie(command.Stars, movie, cancellationToken);

            await _movieRepository.UpdateMovie(movie, cancellationToken);

            return ApiModel.Success();
        }
    }
}