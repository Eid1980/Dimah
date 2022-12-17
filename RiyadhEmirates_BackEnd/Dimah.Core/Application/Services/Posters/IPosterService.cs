using Dimah.Core.Application.Dtos;
using Dimah.Core.Application.Dtos.Search;
using Dimah.Core.Application.Response;

namespace Dimah.Core.Application.Services.Posters
{
    public interface IPosterService
    {
        IApiResponse GetById(Guid id);
        IApiResponse GetAll();
        IApiResponse GetAll(SearchModel searchModel);
        IApiResponse Create(CreatePosterDto createModel);
        IApiResponse Update(UpdatePosterDto updateModel);
        IApiResponse ChangeStatus(Guid id);
        IApiResponse Delete(Guid id);
    }
}
