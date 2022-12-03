using System.Globalization;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Dimah.Core.Application.Services.Shared;

namespace Dimah.API.Controllers
{
    [Authorize]
    [ApiController]
    [Produces("application/json")]
    public class BaseController : ControllerBase
    {
        readonly ILocalizationService _localizationService;
        public BaseController(ILocalizationService localizationService)
        {
            _localizationService = localizationService;
        }

        public int UserId
        {
            get
            {
                if (User.Identity.IsAuthenticated)
                {
                    int.TryParse(User.Claims.FirstOrDefault(c => c.Type.ToLower().Contains("userid")).Value, out int userId);
                    return userId;
                }
                else return 0;
            }
        }

        public string GetCurrentCultureName => _localizationService.GetCurrentCultureName;
        public string GetCurrentUICultureName => _localizationService.GetCurrentUICultureName;
        public CultureInfo GetCurrentCulture => _localizationService.GetCurrentCulture;
        public CultureInfo GetCurrentUICulture => _localizationService.GetCurrentUICulture;

        //public IResponse<TReturnedEntity> GetResponse<TReturnedEntity>(TReturnedEntity entity, string message = null)
        //   where TReturnedEntity : class
        //{
        //    return new Response<TReturnedEntity>
        //    {
        //        Message = message,
        //        Entity = entity
        //    };
        //}
    }
}
