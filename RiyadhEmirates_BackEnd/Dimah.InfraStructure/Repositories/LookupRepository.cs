using Dimah.Core.Domain.Entities;
using Dimah.Core.Domain.IRepositories;
using Dimah.InfraStructure.Contexts;

namespace Dimah.InfraStructure.Repositories
{
    public class LookupRepository : ILookupRepository
    {
        private DimahContext _context;
        public LookupRepository(DimahContext context)
        {
            _context = context;
        }

        public IQueryable<Nationality> GetNationalities()
        {
            return _context.Nationalities.AsQueryable();
        }
    }
}
