using FreshShop.DataAccess.Abstract;
using FreshShop.DataAccess.Context;
using FreshShop.Model.Entity;
using System.Collections.Generic;

namespace FreshShop.DataAccess.Concrete
{
    public class ProductRepository : RepositoryBase<Product,FreshShopDbContext>,IProductRepository
    {      
        public List<Product> GetByCategoryID(int CategoryID)
        {
           return GetAll(x => x.CategoryID == CategoryID);
        }
        public List<Product> GetByPriceRange(decimal MinPrice, decimal MaxPrice)
        {
            return GetAll(x => x.Price >= MinPrice && x.Price <= MaxPrice);
        }

    }
}
