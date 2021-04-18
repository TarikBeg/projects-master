using System;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using MistralTask.Business.Commands;
using MistralTask.Business.Queries;
using SharedKernel.Extensions;

namespace MistralTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : Controller
    {
        private readonly IMediator _dispatcher;

        public MovieController(IMediator dispatcher)
        {
            _dispatcher = dispatcher;
        }

        [HttpGet]
        public async Task<IActionResult> Get(string keyword, int page, int pageSize)
        {
            var response =
                await _dispatcher.Send(new GetMovies.Query(page, pageSize, keyword));

            return response.ToActionResult();
        }

        [HttpPost("{movieId}")]
        public async Task<IActionResult> AddStars(Guid movieId, AddStarsForMovie.Command command)
        {
            command.MovieId = movieId; 

            var response =
                await _dispatcher.Send(command);

            return response.ToActionResult();
        }
    }
}