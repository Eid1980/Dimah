using Dimah.Core.Application.Dtos;
using Dimah.Core.Application.Dtos.Search;
using Dimah.Core.Application.Response;

namespace Dimah.Core.Application.Services.CharityProjects
{
    public interface ICharityProjectService
    {
        IApiResponse GetById(int id);
        IApiResponse GetByCharityId(int id);
        IApiResponse GetAll();
        IApiResponse GetAll(SearchModel searchModel);
        IApiResponse Create(CreateCharityProjectDto createModel);
        IApiResponse Update(UpdateCharityProjectDto updateModel);
        IApiResponse ChangeStatus(int id);
        IApiResponse Delete(int id);
        IApiResponse GetLookupList();
    }
}
