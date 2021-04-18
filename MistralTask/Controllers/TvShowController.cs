using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using MistralTask.Business.Queries;
using SharedKernel.Extensions;

namespace MistralTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TvShowController : Controller
    {
        private readonly IMediator _dispatcher;

        public TvShowController(IMediator dispatcher)
        {
            _dispatcher = dispatcher;
        }

        [HttpGet]
        public async Task<IActionResult> Get(string keyword, int page, int pageSize)
        {
            var response =
                await _dispatcher.Send(new GetTvShows.Query(page, pageSize, keyword));

            return response.ToActionResult();
        }
    }
}