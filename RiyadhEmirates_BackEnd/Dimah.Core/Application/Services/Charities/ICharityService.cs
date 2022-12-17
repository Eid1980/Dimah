using Dimah.Core.Application.Dtos;
using Dimah.Core.Application.Dtos.Search;
using Dimah.Core.Application.Response;

namespace Dimah.Core.Application.Services.Charities
{
    public interface ICharityService
    {
        IApiResponse GetById(Guid id);
        IApiResponse GetAll();
        IApiResponse GetAll(SearchModel searchModel);
        IApiResponse Create(CreateCharityDto createModel);
        IApiResponse Update(UpdateCharityDto updateModel);
        IApiResponse ChangeStatus(Guid id);
        IApiResponse Delete(Guid id);
        IApiResponse GetLookupList();
    }
}
