using Dimah.Core.Application.Response;

namespace Dimah.Core.Application.Services.Lookups
{
    public interface ILookupService
    {
        IApiResponse GetNationalityLookupList();
    }
}
