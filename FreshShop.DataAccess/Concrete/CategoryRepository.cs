using FreshShop.DataAccess.Abstract;
using FreshShop.DataAccess.Context;
using FreshShop.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshShop.DataAccess.Concrete
{
    public class CategoryRepository : RepositoryBase<Category, FreshShopDbContext>, ICategoryRepository
    {

    }
}
