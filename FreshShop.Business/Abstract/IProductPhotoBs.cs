using FreshShop.Business.Concrete;
using FreshShop.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FreshShop.Business.Abstract
{
    public interface IProductPhotoBs
    {
        List<ProductPhoto> GetAll(Expression<Func<ProductPhoto, bool>> filter = null);
        ProductPhoto Get(Expression<Func<ProductPhoto, bool>> filter);
        ProductPhoto GetById(int id);
        int Insert(ProductPhoto entity);
        void Update(ProductPhoto entity);
        void Delete(ProductPhoto entity);
    }
}
