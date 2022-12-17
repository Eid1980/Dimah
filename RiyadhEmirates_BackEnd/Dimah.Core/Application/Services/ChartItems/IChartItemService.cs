using Dimah.Core.Application.Dtos;
using Dimah.Core.Application.Response;

namespace Dimah.Core.Application.Services.ChartItems
{
    public interface IChartItemService
    {
        IApiResponse GetById(Guid id);
        IApiResponse GetCurrentChart();
        IApiResponse Create(CreateChartItemDto createModel);
        IApiResponse Update(UpdateChartItemDto updateModel);
        IApiResponse Delete(Guid id);
        IApiResponse FinishPayment();
    }
}
