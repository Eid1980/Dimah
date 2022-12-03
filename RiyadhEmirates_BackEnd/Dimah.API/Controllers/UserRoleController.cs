using Dimah.Core.Application.Dtos;
using Dimah.Core.Application.Dtos.Search;
using Dimah.Core.Application.Response;
using Dimah.Core.Application.Services.Shared;
using Dimah.Core.Application.Services.UserRoles;
using Microsoft.AspNetCore.Mvc;

namespace Dimah.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserRoleController : BaseController, IUserRoleService
    {
        private readonly IUserRoleService _userRoleService;
        public UserRoleController(ILocalizationService localizationService,
            IUserRoleService userRoleService) : base(localizationService)
        {
            _userRoleService = userRoleService;
        }

        [HttpGet("GetUsersByRoleId/{roleId}")]
        public IApiResponse GetUsersByRoleId(int roleId)
        {
            return _userRoleService.GetUsersByRoleId(roleId);
        }

        [HttpGet("GetRolesByUserId/{userId}")]
        public IApiResponse GetRolesByUserId(int userId)
        {
            return _userRoleService.GetRolesByUserId(userId);
        }

        [HttpPost("Create")]
        public IApiResponse Create(CreateUserRoleDto createDto)
        {
            return _userRoleService.Create(createDto);
        }

        [HttpDelete("Delete/{id}")]
        public IApiResponse Delete(int id)
        {
            return _userRoleService.Delete(id);
        }

        [HttpPost("GetListPage")]
        public IApiResponse GetAdminUsers(SearchModel searchModelDto)
        {
            return _userRoleService.GetAdminUsers(searchModelDto);
        }

        [HttpGet("IsAuthorize/{roles}")]
        public IApiResponse IsAuthorize(string roles)
        {
            return _userRoleService.IsAuthorize(roles);
        }

    }
}
