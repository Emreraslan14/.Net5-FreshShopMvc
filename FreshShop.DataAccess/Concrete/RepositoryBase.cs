using FreshShop.DataAccess.Abstract;
using FreshShop.Model.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace FreshShop.DataAccess.Concrete
{
    public class RepositoryBase<TEntity,TContext> : IRepository<TEntity>
        where TEntity : BaseEntity, new()
        where TContext : DbContext, new()
    {
        public void Delete(TEntity entity)
        {
            using (TContext ctx = new TContext())
            {
                ctx.Entry(entity).State = EntityState.Deleted;
                ctx.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext ctx = new TContext())
            {
                return ctx.Set<TEntity>().SingleOrDefault(filter);                
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext ctx = new TContext())
            {
                if (filter == null)
                    return ctx.Set<TEntity>().ToList();
                else
                    return ctx.Set<TEntity>().Where(filter).ToList();
            }         
        }

        public TEntity GetById(int id)
        {
            using (TContext ctx = new TContext())
            {
                return ctx.Set<TEntity>().SingleOrDefault(x => x.ID == id);
            }
        }

        public int Insert(TEntity entity)
        {
             using (TContext ctx = new TContext())
             {
                ctx.Entry(entity).State = EntityState.Added;
                return ctx.SaveChanges();
             }
        }

        public void Update(TEntity entity)
        {
            using (TContext ctx = new TContext())
            {
                ctx.Entry(entity).State = EntityState.Modified;
                ctx.SaveChanges();
            }
        }
    }
}
