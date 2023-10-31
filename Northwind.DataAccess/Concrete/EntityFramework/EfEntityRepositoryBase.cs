using Northwind.DataAccess.Abstract;
using Northwind.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity> where TEntity : class, IEntity, new() where TContext : DbContext, new()
    {
        public void Add(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var addedEntity = context.Entry(entity); //ENTRY DAHIL ETMEK DEMEK.
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted; //ENTİTYNIN DURUMU DEMEKTIR. STATE DURUM DEMEKTIR.
                context.SaveChanges();
            }
        }

        public TEntity get(Expression<Func<TEntity, bool>> predicate)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(predicate);
            }


        }
        

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate = null)
        {
            using(TContext context = new TContext())
            {
                return predicate==null?context.Set<TEntity>().ToList()
                    :context.Set<TEntity>().Where(predicate).ToList();
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified; //ENTİTYNIN DURUMU DEMEKTIR. STATE DURUM DEMEKTIR.
                context.SaveChanges();
            }
        }
    }
}
