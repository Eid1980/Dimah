using Microsoft.EntityFrameworkCore;
using Dimah.Core.Domain.IRepositories;
using System.Linq.Expressions;
using Dimah.InfraStructure.Contexts;

namespace Dimah.InfraStructure.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity>
        where TEntity: class
    {
        protected DimahContext _context;

        public Repository(DimahContext context)
        {
            _context = context;
        }

        #region Filters
        public virtual TEntity Find(object id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public virtual TEntity SingleOrDefault(Expression<Func<TEntity, bool>> filter = null,
            params Expression<Func<TEntity, object>>[] includes)
        {
            IQueryable<TEntity> query = _context.Set<TEntity>();

            query = includes.Aggregate(query, (current, include) => current.Include(include));

            return filter != null ? query.SingleOrDefault(filter) : query.SingleOrDefault();
        }

        public virtual TEntity FirstOrDefault(Expression<Func<TEntity, bool>> filter = null,
            params Expression<Func<TEntity, object>>[] includes)
        {
            IQueryable<TEntity> query = _context.Set<TEntity>();

            query = includes.Aggregate(query, (current, include) => current.Include(include));

            return filter != null ? query.FirstOrDefault(filter) : query.FirstOrDefault();
        }

        public virtual bool Any(Expression<Func<TEntity, bool>> filter)
        {
            IQueryable<TEntity> query = _context.Set<TEntity>();
            return query.Any(filter);
        }

        #region Where
        public virtual IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> predicate)
        {
            return _context.Set<TEntity>().Where(predicate);
        }

        public virtual IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> filter = null,
            params Expression<Func<TEntity, object>>[] includes)
        {
            IQueryable<TEntity> query = _context.Set<TEntity>();

            query = includes.Aggregate(query, (current, include) => current.Include(include));

            if (filter != null)
                query = query.Where(filter);

            return query;
        }

        public virtual IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            params Expression<Func<TEntity, object>>[] includes)
        {
            IQueryable<TEntity> query = _context.Set<TEntity>();

            query = includes.Aggregate(query, (current, include) => current.Include(include));

            if (filter != null)
                query = query.Where(filter);

            if (orderBy != null)
                query = orderBy(query);

            return query;
        }

        //public IEnumerable<TReturnedVM> Where<TReturnedVM>(Expression<Func<TEntity, bool>> filter = null,
        //    Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
        //    params Expression<Func<TEntity, object>>[] includes)
        //{
        //    IQueryable<TEntity> query = _context.Set<TEntity>();

        //    query = includes.Aggregate(query, (current, include) => current.Include(include));

        //    if (filter != null)
        //        query = query.Where(filter);

        //    if (orderBy != null)
        //        query = orderBy(query);

        //    return query.ProjectTo<TReturnedVM>(_mapConfig).ToList();
        //}

        #endregion
        #endregion

        #region Paging
        public virtual IQueryable<TEntity> PageAll(int skip, int take)
        {
            return _context.Set<TEntity>().Skip(skip).Take(take);
        }

        public virtual IQueryable<TEntity> PageAll(int skip, int take, Expression<Func<TEntity, bool>> predicate)
        {
            return _context.Set<TEntity>().Where(predicate).Skip(skip).Take(take);
        }

        public virtual IQueryable<TEntity> PageAll(int skip, int take, params Expression<Func<TEntity, object>>[] includes)
        {
            IQueryable<TEntity> query = _context.Set<TEntity>();
            query = includes.Aggregate(query, (current, include) => current.Include(include));

            return query.Skip(skip).Take(take);
        }

        public virtual IQueryable<TEntity> PageAll(int skip, int take, Expression<Func<TEntity, bool>> filter = null,
            params Expression<Func<TEntity, object>>[] includes)
        {
            IQueryable<TEntity> query = _context.Set<TEntity>();

            query = includes.Aggregate(query, (current, include) => current.Include(include));

            if (filter != null)
                query = query.Where(filter);

            return query.Skip(skip).Take(take);
        }
        #endregion

        #region Include
        public virtual IQueryable<TEntity> Include(Expression<Func<TEntity, object>> predicate)
        {
            IQueryable<TEntity> query = _context.Set<TEntity>();
            return query.Include(predicate);
        }

        public virtual IQueryable<TEntity> IncludeMultiple(params Expression<Func<TEntity, object>>[] includeProperties)
        {
            IQueryable<TEntity> query = _context.Set<TEntity>();
            if (includeProperties != null)
            {
                foreach (var item in includeProperties)
                {
                    query = query.Include(item);
                }

                return query;
            }

            return query;
        }

        public virtual IQueryable<TEntity> IncludeMultiple(params string[] includeProperties)
        {
            IQueryable<TEntity> query = _context.Set<TEntity>();
            if (includeProperties != null)
            {
                foreach (var item in includeProperties)
                {
                    query = query.Include(item);
                }

                return query;
            }

            return query;
        }
        #endregion

        #region Aggregation
        public virtual int Max(Func<TEntity, int> selector)
        {
            if (_context.Set<TEntity>().Any())
            {
                return _context.Set<TEntity>().Max(selector);
            }
            else
            {
                return 0;
            }
        }

        public virtual long Max(Func<TEntity, long> selector)
        {
            if (_context.Set<TEntity>().Any())
            {
                return _context.Set<TEntity>().Max(selector);
            }
            else
            {
                return 0;
            }
        }

        public virtual int Count()
        {
            return _context.Set<TEntity>().Count();
        }

        public virtual int Count(Expression<Func<TEntity, bool>> predicate)
        {
            return _context.Set<TEntity>().Count(predicate);
        }
        #endregion

        #region Add
        public TEntity Add(TEntity entity)
        {
            return _context.Set<TEntity>().Add(entity).Entity;
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            _context.Set<TEntity>().AddRange(entities);
        }

        // Deprecated
        //public void AddOrUpdate(TEntity entity)
        //{
        //    _context.Set<TEntity>().AddOrUpdate(entity);
        //}

        public void Update(TEntity entity, object newValue)
        {
            _context.Entry<TEntity>(entity).CurrentValues.SetValues(newValue);
        }

        #endregion

        #region Remove

        public bool Remove(object id)
        {
            var entity = Find(id);
            if (entity == null)
                return false;

            _context.Set<TEntity>().Remove(entity);
            return true;
        }

        public void Remove(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            _context.Set<TEntity>().RemoveRange(entities);
        }

        #endregion

        public IQueryable<TEntity> GetQueryable()
        {
            return _context.Set<TEntity>().AsQueryable();
        }
    }
}
