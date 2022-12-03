using Dimah.Core.Application.Dtos;
using Dimah.Core.Application.Response;
using Dimah.Core.Domain.IRepositories;

namespace Dimah.Core.Application.Services.Lookups
{
    public class LookupService: BaseService, ILookupService
    {
        private readonly ILookupRepository _lookupRepository;
        public LookupService(ILookupRepository lookupRepository)
        {
            _lookupRepository = lookupRepository;
        }

        public IApiResponse GetNationalityLookupList()
        {
            return GetResponse(data: _lookupRepository.GetNationalities().Where(l => l.IsActive).Select(item =>
            new LookupDto<int>
            {
                Id = item.Id,
                Name = item.NameAr
            }).ToList());
        }
    }
}
