using FreshShop.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FreshShop.DataAccess.Abstract
{
    public interface IRepository<TEntity> 
        where TEntity :BaseEntity,new()
    {
        List<TEntity> GetAll(Expression<Func<TEntity,bool>> filter = null); //Where metodu kullanırken istenilen parametreyi
                                                                            //burda da istememiz gerekiyor.
        TEntity Get(Expression<Func<TEntity, bool>> filter); 
        TEntity GetById(int id);
        int Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);

    }
}
