using Dimah.Core.Application.Response;
using Dimah.Core.Application.Services.Lookups;
using Dimah.Core.Application.Services.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Dimah.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LookupController : BaseController, ILookupService
    {
        private readonly ILookupService _lookupService;
        public LookupController(ILookupService lookupService, ILocalizationService localizationService) : base(localizationService)
        {
            _lookupService=lookupService;
        }


        [AllowAnonymous, HttpGet("GetNationalityLookupList")]
        public IApiResponse GetNationalityLookupList()
        {
            return _lookupService.GetNationalityLookupList();
        }
    }
}
