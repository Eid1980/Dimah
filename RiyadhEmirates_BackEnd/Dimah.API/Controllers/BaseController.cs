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

        public Guid? UserId
        {
            get
            {
                if (User.Identity.IsAuthenticated)
                {
                    Guid.TryParse(User.Claims.FirstOrDefault(c => c.Type.ToLower().Contains("userid")).Value, out Guid userId);
                    return userId;
                }
                else 
                    return null;
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
