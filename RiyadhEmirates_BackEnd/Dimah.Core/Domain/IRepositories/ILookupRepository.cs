using Dimah.Core.Domain.Entities;

namespace Dimah.Core.Domain.IRepositories
{
    public interface ILookupRepository
    {
        IQueryable<Nationality> GetNationalities();
    }
}
