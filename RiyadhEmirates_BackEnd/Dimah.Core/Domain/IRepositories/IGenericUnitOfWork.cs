namespace Dimah.Core.Domain.IRepositories
{
    public interface IGenericUnitOfWork
    {
        IRepository<T> Repository<T>() where T : class;
        bool ContextSaveChanges();
    }
}
