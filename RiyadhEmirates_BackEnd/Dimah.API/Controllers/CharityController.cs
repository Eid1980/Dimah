using Dimah.Core.Application.Dtos;
using Dimah.Core.Application.Dtos.Search;
using Dimah.Core.Application.Response;
using Dimah.Core.Application.Services.Charities;
using Dimah.Core.Application.Services.Shared;
using Microsoft.AspNetCore.Mvc;

namespace Dimah.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharityController : BaseController, ICharityService
    {
        private readonly ICharityService _charityService;
        public CharityController(ILocalizationService localizationService,
            ICharityService charityService) : base(localizationService)
        {
            _charityService = charityService;
        }

        [HttpGet("GetById/{id}")]
        public IApiResponse GetById(Guid id)
        {
            return _charityService.GetById(id);
        }
        [HttpPost("GetListPage")]
        public IApiResponse GetAll(SearchModel searchModelDto)
        {
            return _charityService.GetAll(searchModelDto);
        }
        [HttpGet("GetAll")]
        public IApiResponse GetAll()
        {
            return _charityService.GetAll();
        }

        [HttpPost("Create")]
        public IApiResponse Create(CreateCharityDto createDto)
        {
            return _charityService.Create(createDto);
        }
        [HttpPut("Update")]
        public IApiResponse Update(UpdateCharityDto updateDto)
        {
            return _charityService.Update(updateDto);
        }
        [HttpGet("ChangeStatus/{id}")]
        public IApiResponse ChangeStatus(Guid id)
        {
            return _charityService.ChangeStatus(id);
        }

        [HttpDelete("Delete/{id}")]
        public IApiResponse Delete(Guid id)
        {
            return _charityService.Delete(id);
        }

        [HttpGet("GetLookupList")]
        public IApiResponse GetLookupList()
        {
            return _charityService.GetLookupList();
        }
    }
}
