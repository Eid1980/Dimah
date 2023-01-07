using Dimah.Core.Application.Dtos;
using Dimah.Core.Application.Response;

namespace Dimah.Core.Application.Services.DailyRequests
{
    public interface IDailyRequestService
    {
        IApiResponse Create(CreateDailyRequestDto createModel);
        IApiResponse PayRequest(Guid id);
        IApiResponse GetRequestProfile();
        IApiResponse GetRequestDashBoard();
        IApiResponse GetRequestDetailsById(Guid id);
        IApiResponse Delete(Guid id);
    }
}
