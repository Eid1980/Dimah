using Dimah.Core.Application.Response;
using Dimah.Core.Application.Services.Home;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dimah.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase, IHomeService
    {
        private readonly IHomeService _homeService;
        public HomeController(IHomeService homeService)
        {
            _homeService = homeService;
        }

        [HttpGet("GetCharityProjects/{id}")]
        public IApiResponse GetCharityProjects(Guid id)
        {
            return _homeService.GetCharityProjects(id);
        }
        [HttpGet("GetDimahTopProjects")]
        public IApiResponse GetDimahTop4Projects()
        {
            return _homeService.GetDimahTop4Projects();
        }

        [HttpGet("GetProjectDetails/{id}")]
        public IApiResponse GetProjectDetails(Guid id)
        {
            return _homeService.GetProjectDetails(id);
        }
    }
}
