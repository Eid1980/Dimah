using Dimah.Core.Application.Dtos;
using Dimah.Core.Application.Response;
using Dimah.Core.Application.Services.DailyRequests;
using Microsoft.AspNetCore.Mvc;

namespace Dimah.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DailyRequestController : ControllerBase, IDailyRequestService
    {
        private readonly IDailyRequestService _dailyRequestController;
        public DailyRequestController(IDailyRequestService dailyRequestController)
        {
            _dailyRequestController = dailyRequestController;
        }

        [HttpPost("Create")]
        public IApiResponse Create(CreateDailyRequestDto createDto)
        {
            return _dailyRequestController.Create(createDto);
        }

        [HttpGet("PayRequest/{id}")]
        public IApiResponse PayRequest(Guid id)
        {
            return _dailyRequestController.PayRequest(id);
        }

        [HttpGet("GetRequestProfile")]
        public IApiResponse GetRequestProfile()
        {
            return _dailyRequestController.GetRequestProfile();
        }
        [HttpGet("GetRequestDashBoard")]
        public IApiResponse GetRequestDashBoard()
        {
            return _dailyRequestController.GetRequestDashBoard();
        }

        [HttpGet("GetRequestDetailsById/{id}")]
        public IApiResponse GetRequestDetailsById(Guid id)
        {
            return _dailyRequestController.GetRequestDetailsById(id);
        }

        [HttpDelete("Delete/{id}")]
        public IApiResponse Delete(Guid id)
        {
            return _dailyRequestController.Delete(id);
        }

    }
}
