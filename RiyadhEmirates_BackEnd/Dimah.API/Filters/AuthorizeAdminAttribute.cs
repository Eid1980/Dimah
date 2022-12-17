using Dimah.Core.Application.Services.Accounts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Security.Claims;
using Dimah.Core.Application.Shared;

namespace Dimah.API.Filters
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public class AuthorizeAdminAttribute : TypeFilterAttribute
    {
        public AuthorizeAdminAttribute(params int[] roles) : base(typeof(AuthorizeAdminFilter))
        {
            Arguments = new object[] { roles };
        }
        public class AuthorizeAdminFilter : IAuthorizationFilter
        {
            int[] _roles;
            private readonly IAccountService _accountService;
            public AuthorizeAdminFilter(IAccountService accountService, params int[] roles)
            {
                _accountService = accountService;
                _roles = roles;
            }

            public void OnAuthorization(AuthorizationFilterContext context)
            {
                _roles = _roles.Concat(new int[] { (int)SystemEnums.Roles.SuperSystemAdmin }).ToArray();
                bool flagClaim = false;
                if (_roles.Length > 0)
                {
                    Guid.TryParse(((ClaimsIdentity)context.HttpContext.User.Identity).Claims.FirstOrDefault(c => c.Type.ToLower().Contains("userid")).Value, out Guid userId);
                    flagClaim = _accountService.IsUserInRoles(userId, _roles);
                }
                else
                    flagClaim = true;

                if (!flagClaim)
                {
                    context.ModelState.AddModelError("UnAuthorized", "You Are Not Authorized");
                    context.Result = new UnauthorizedObjectResult(context.ModelState);
                }
                return;
            }


        }
    }
}
