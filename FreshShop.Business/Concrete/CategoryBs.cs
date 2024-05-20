using FreshShop.Business.Abstract;
using FreshShop.DataAccess.Abstract;
using FreshShop.Model.Entity;

namespace FreshShop.Business.Concrete
{
    public class CategoryBs : Business<Category, IRepository<Category>>, ICategoryBs
    {
        public CategoryBs(IRepository<Category> repo) : base(repo)
        {
        }
    }
}
