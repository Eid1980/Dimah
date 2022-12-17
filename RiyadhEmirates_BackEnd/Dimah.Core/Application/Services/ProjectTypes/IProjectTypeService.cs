using Dimah.Core.Application.Dtos;
using Dimah.Core.Application.Dtos.Search;
using Dimah.Core.Application.Response;

namespace Dimah.Core.Application.Services.ProjectTypes
{
    public interface IProjectTypeService
    {
        IApiResponse GetById(Guid id);
        IApiResponse GetAll();
        IApiResponse GetAll(SearchModel searchModel);
        IApiResponse Create(CreateProjectTypeDto createModel);
        IApiResponse Update(UpdateProjectTypeDto updateModel);
        IApiResponse ChangeStatus(Guid id);
        IApiResponse Delete(Guid id);
        IApiResponse GetLookupList();
    }
}
