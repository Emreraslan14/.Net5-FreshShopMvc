using FreshShop.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FreshShop.Business.Abstract
{
    public interface IProductBs
    {
        List<Product> GetAll(Expression<Func<Product, bool>> filter = null);
        Product Get(Expression<Func<Product, bool>> filter);
        Product GetById(int id);
        int Insert(Product entity);
        void Update(Product entity);
        void Delete(Product entity);
        List<Product> GetByCategoryID(int CategoryID);
        List<Product> GetByPriceRange(decimal MinPrice, decimal MaxPrice);
    }
}
