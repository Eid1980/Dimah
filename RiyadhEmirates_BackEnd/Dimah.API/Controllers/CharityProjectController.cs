using Dimah.Core.Application.Dtos;
using Dimah.Core.Application.Dtos.Search;
using Dimah.Core.Application.Response;
using Dimah.Core.Application.Services.CharityProjects;
using Dimah.Core.Application.Services.Shared;
using Microsoft.AspNetCore.Mvc;

namespace Dimah.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharityProjectController : BaseController, ICharityProjectService
    {
        private readonly ICharityProjectService _charityProjectService;
        public CharityProjectController(ILocalizationService localizationService,
            ICharityProjectService charityProjectService) : base(localizationService)
        {
            _charityProjectService = charityProjectService;
        }

        [HttpGet("GetById/{id}")]
        public IApiResponse GetById(Guid id)
        {
            return _charityProjectService.GetById(id);
        }
        [HttpGet("GetByCharityId/{id}")]
        public IApiResponse GetByCharityId(Guid id)
        {
            return _charityProjectService.GetByCharityId(id);
        }
        [HttpPost("GetListPage")]
        public IApiResponse GetAll(SearchModel searchModelDto)
        {
            return _charityProjectService.GetAll(searchModelDto);
        }
        [HttpGet("GetAll")]
        public IApiResponse GetAll()
        {
            return _charityProjectService.GetAll();
        }

        [HttpPost("Create")]
        public IApiResponse Create(CreateCharityProjectDto createDto)
        {
            return _charityProjectService.Create(createDto);
        }
        [HttpPut("Update")]
        public IApiResponse Update(UpdateCharityProjectDto updateDto)
        {
            return _charityProjectService.Update(updateDto);
        }
        [HttpGet("ChangeStatus/{id}")]
        public IApiResponse ChangeStatus(Guid id)
        {
            return _charityProjectService.ChangeStatus(id);
        }

        [HttpDelete("Delete/{id}")]
        public IApiResponse Delete(Guid id)
        {
            return _charityProjectService.Delete(id);
        }

        [HttpGet("GetLookupList")]
        public IApiResponse GetLookupList()
        {
            return _charityProjectService.GetLookupList();
        }

    }
}
