using FreshShop.Business.Abstract;
using FreshShop.DataAccess.Abstract;
using FreshShop.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace FreshShop.Business.Concrete
{
    public class Business<TEntity,TRepo> : IBusiness<TEntity>
        where TEntity : BaseEntity, new()
        where TRepo : IRepository<TEntity>
    {
        private readonly TRepo _repo;
        public Business(TRepo repo)
        {
            _repo = repo;
        }
        public void Delete(TEntity entity)
        {
            _repo.Delete(entity);
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            return _repo.Get(filter);
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            return _repo.GetAll(filter);
        }

        public TEntity GetById(int id)
        {
            return _repo.GetById(id);
        }

        public int Insert(TEntity entity)
        {
            return _repo.Insert(entity);
        }

        public void Update(TEntity entity)
        {
            _repo.Update(entity);
        }
    }
}
