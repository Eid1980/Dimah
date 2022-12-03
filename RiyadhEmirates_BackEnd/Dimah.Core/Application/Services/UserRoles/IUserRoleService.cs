using Dimah.Core.Application.Dtos;
using Dimah.Core.Application.Dtos.Search;
using Dimah.Core.Application.Response;

namespace Dimah.Core.Application.Services.UserRoles
{
    public interface IUserRoleService
    {
        IApiResponse GetUsersByRoleId(int roleId);
        IApiResponse GetRolesByUserId(int userId);
        IApiResponse Create(CreateUserRoleDto createModel);
        IApiResponse Delete(int id);
        IApiResponse GetAdminUsers(SearchModel searchModel);
        IApiResponse IsAuthorize(string roles);
    }
}
