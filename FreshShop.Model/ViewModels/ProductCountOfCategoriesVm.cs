using FreshShop.Model.Entity;
using System.Collections.Generic;

namespace FreshShop.Model.ViewModels
{
    public class ProductCountOfCategoriesVm
    {
        public List<Product> Products { get; set; }
        public List<Category> Categories { get; set; }
    }
}
