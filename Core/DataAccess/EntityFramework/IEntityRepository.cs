using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.EntityFramework
{
    //public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>

    public interface IEntityRepository<T> where T : IEntity
    {
		List<T> GetAll(Expression<Func<T, bool>>? filter = null);
		T Get(Expression<Func<T, bool>>? filter = null);
		void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}
