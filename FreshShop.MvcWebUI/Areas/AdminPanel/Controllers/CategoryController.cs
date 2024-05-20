using FreshShop.Business.Abstract;
using FreshShop.Model.Entity;
using FreshShop.Model.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FreshShop.MvcWebUI.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class CategoryController : Controller
    {
        private readonly ICategoryBs _categoryBs;
        private readonly IProductBs _productBs;
        public CategoryController(ICategoryBs categoryBs, IProductBs productBs)
        {
            _categoryBs = categoryBs;
            _productBs = productBs;
        }
        public IActionResult Index()
        {
            List<Category> categories = _categoryBs.GetAll();
            List<Product> products = _productBs.GetAll();
            
            ProductCountOfCategoriesVm vm = new ProductCountOfCategoriesVm();
            vm.Categories = categories;
            vm.Products = products;

            return View(vm);
        }
    }
}
