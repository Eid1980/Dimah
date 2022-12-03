using Dimah.Core.Application.Dtos;
using Dimah.Core.Application.Dtos.Search;
using Dimah.Core.Application.Response;
using Dimah.Core.Application.Services.Roles;
using Dimah.Core.Application.Services.Shared;
using Microsoft.AspNetCore.Mvc;

namespace Dimah.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : BaseController, IRoleService
    {
        private readonly IRoleService _roleService;
        public RoleController(ILocalizationService localizationService,
            IRoleService roleService) : base(localizationService)
        {
            _roleService = roleService;
        }

        [HttpGet("GetById/{id}")]
        public IApiResponse GetById(int id)
        {
            return _roleService.GetById(id);
        }
        [HttpPost("GetListPage")]
        public IApiResponse GetAll(SearchModel searchModelDto)
        {
            return _roleService.GetAll(searchModelDto);
        }
        [HttpGet("GetAll")]
        public IApiResponse GetAll()
        {
            return _roleService.GetAll();
        }

        [HttpPost("Create")]
        public IApiResponse Create(CreateRoleDto createDto)
        {
            return _roleService.Create(createDto);
        }
        [HttpPut("Update")]
        public IApiResponse Update(UpdateRoleDto updateDto)
        {
            return _roleService.Update(updateDto);
        }
        [HttpGet("ChangeStatus/{id}")]
        public IApiResponse ChangeStatus(int id)
        {
            return _roleService.ChangeStatus(id);
        }

        [HttpDelete("Delete/{id}")]
        public IApiResponse Delete(int id)
        {
            return _roleService.Delete(id);
        }

        [HttpGet("GetLookupList")]
        public IApiResponse GetLookupList()
        {
            return _roleService.GetLookupList();
        }
    }
}
