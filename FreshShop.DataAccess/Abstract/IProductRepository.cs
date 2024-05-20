using FreshShop.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshShop.DataAccess.Abstract
{
    public interface IProductRepository : IRepository<Product>
    {
        List<Product> GetByCategoryID(int CategoryID);
        List<Product> GetByPriceRange(decimal MinPrice, decimal MaxPrice);
    }
}
