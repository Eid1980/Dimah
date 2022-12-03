using Dimah.Core.Application.Dtos;
using Dimah.Core.Application.Dtos.Search;
using Dimah.Core.Application.Response;
using Dimah.Core.Application.Services.ProjectTypes;
using Dimah.Core.Application.Services.Shared;
using Microsoft.AspNetCore.Mvc;

namespace Dimah.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectTypeController : BaseController, IProjectTypeService
    {
        private readonly IProjectTypeService _projectTypeService;
        public ProjectTypeController(ILocalizationService localizationService,
            IProjectTypeService projectTypeService) : base(localizationService)
        {
            _projectTypeService = projectTypeService;
        }

        [HttpGet("GetById/{id}")]
        public IApiResponse GetById(int id)
        {
            return _projectTypeService.GetById(id);
        }
        [HttpPost("GetListPage")]
        public IApiResponse GetAll(SearchModel searchModelDto)
        {
            return _projectTypeService.GetAll(searchModelDto);
        }
        [HttpGet("GetAll")]
        public IApiResponse GetAll()
        {
            return _projectTypeService.GetAll();
        }

        [HttpPost("Create")]
        public IApiResponse Create(CreateProjectTypeDto createDto)
        {
            return _projectTypeService.Create(createDto);
        }
        [HttpPut("Update")]
        public IApiResponse Update(UpdateProjectTypeDto updateDto)
        {
            return _projectTypeService.Update(updateDto);
        }
        [HttpGet("ChangeStatus/{id}")]
        public IApiResponse ChangeStatus(int id)
        {
            return _projectTypeService.ChangeStatus(id);
        }

        [HttpDelete("Delete/{id}")]
        public IApiResponse Delete(int id)
        {
            return _projectTypeService.Delete(id);
        }

        [HttpGet("GetLookupList")]
        public IApiResponse GetLookupList()
        {
            return _projectTypeService.GetLookupList();
        }
    }
}
