using Dimah.Core.Application.Dtos;
using Dimah.Core.Application.Response;
using Dimah.Core.Application.Services.ChartItems;
using Microsoft.AspNetCore.Mvc;

namespace Dimah.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChartItemController : ControllerBase, IChartItemService
    {
        private readonly IChartItemService _chartItemService;
        public ChartItemController(IChartItemService chartItemService)
        {
            _chartItemService = chartItemService;
        }

        [HttpGet("GetById/{id}")]
        public IApiResponse GetById(Guid id)
        {
            return _chartItemService.GetById(id);
        }
        [HttpGet("GetCurrentChart")]
        public IApiResponse GetCurrentChart()
        {
            return _chartItemService.GetCurrentChart();
        }

        [HttpPost("Create")]
        public IApiResponse Create(CreateChartItemDto createDto)
        {
            return _chartItemService.Create(createDto);
        }
        [HttpPut("Update")]
        public IApiResponse Update(UpdateChartItemDto updateDto)
        {
            return _chartItemService.Update(updateDto);
        }

        [HttpDelete("Delete/{id}")]
        public IApiResponse Delete(Guid id)
        {
            return _chartItemService.Delete(id);
        }

        [HttpPut("FinishPayment")]
        public IApiResponse FinishPayment()
        {
            return _chartItemService.FinishPayment();
        }
    }
}
