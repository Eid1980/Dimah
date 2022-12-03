using Dimah.Core.Domain.IRepositories;
using Dimah.InfraStructure.Contexts;
using System.Collections;

namespace Dimah.InfraStructure.Repositories
{
    public class GenericUnitOfWork : IGenericUnitOfWork
    {
        private readonly DimahContext _dbContext;
        private Hashtable _repositories;
        public GenericUnitOfWork(DimahContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IRepository<T> Repository<T>() where T : class
        {
            if (_repositories == null)
                _repositories = new Hashtable();
            var type = typeof(T).Name;
            if (!_repositories.ContainsKey(type))
            {
                var repositoryType = typeof(Repository<>);
                var repositoryInstance =
                    Activator.CreateInstance(repositoryType
                        .MakeGenericType(typeof(T)), _dbContext);
                _repositories.Add(type, repositoryInstance);
            }
            return (IRepository<T>)_repositories[type];
        }
        public bool ContextSaveChanges()
        {
            try
            {
                int retVal = _dbContext.SaveChanges();
                if (retVal >= 1)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
